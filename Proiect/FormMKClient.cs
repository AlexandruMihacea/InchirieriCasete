using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proiect.Entities;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;


namespace Proiect
{
    public partial class FormMKClient : Form
    {
        private List<Clienti> _clienti;

        public FormMKClient()
        {
            InitializeComponent();
            _clienti = new List<Clienti>();
        }

        public void DisplayClienti()
        {
            lvClienti.Items.Clear();

            foreach(Clienti clienti in _clienti)
            {
                var listViewItem = new ListViewItem(clienti.FirstName);
                listViewItem.SubItems.Add(clienti.LastName);
                listViewItem.SubItems.Add(clienti.Email);
                listViewItem.SubItems.Add(clienti.Telefon.ToString());

                listViewItem.Tag = clienti;

                lvClienti.Items.Add(listViewItem);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string firstName = tbPrenume.Text;
            string lastName = tbNume.Text;
            string Email = tbEmail.Text;
            string Telefon = tbTelefon.Text;


            var clienti = new Clienti(firstName, lastName, int.Parse(Telefon), Email);
            _clienti.Add(clienti);

            DisplayClienti();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Client !");
                return;
            }

            ListViewItem listViewItem = lvClienti.SelectedItems[0];
            Clienti clienti = (Clienti)listViewItem.Tag;

            EditClienti editClienti = new EditClienti(clienti);
            if (editClienti.ShowDialog() == DialogResult.OK)
                DisplayClienti();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Client !");
                return;
            }

            if (MessageBox.Show(
                "Esti sigur ca vrei sa stergi clientul ?",
                "Delete client",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvClienti.SelectedItems[0];
                Clienti clienti = (Clienti)listViewItem.Tag;
                _clienti.Remove(clienti);
                DisplayClienti();
            }

        }


        private void btnSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _clienti);
            }

        }


        private void btnDeserializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _clienti = (List<Clienti>)formatter.Deserialize(stream);
                DisplayClienti();
            }
        }



        private void btnXMLSerializare_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
            using (FileStream stream = File.Create("serialized.xml"))
            {
                serializer.Serialize(stream, _clienti);
            }
        }


        private void btnXMLDeserializare_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
            using (FileStream stream = File.OpenRead("serialized.xml"))
            {
                _clienti = (List<Clienti>)serializer.Deserialize(stream);
                DisplayClienti();
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File | *.csv";
            saveFileDialog.Title = "Export CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("\"Numele\", \"Prenumele\", \"Email\", \"Telefon\"");
                    foreach(Clienti clienti in _clienti)
                    {
                        writer.WriteLine($"\"{clienti.LastName}\",\"{clienti.FirstName}\",{clienti.Email}\",\"{clienti.Telefon}");
                    }
                }
            }
        }

       

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            string nume = tbNume.Text.Trim();
            if(nume.Length < 3)
            {
                errorProvider1.SetError(tbNume, "Nume invalid !");
                e.Cancel = true;
            }
        }

        private void tbNume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbNume, null);
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            string prenume = tbPrenume.Text.Trim();
            if (prenume.Length < 3)
            {
                errorProvider1.SetError(tbPrenume, "Prenume invalid !");
                e.Cancel = true;
            }
        }

        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPrenume, null);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbEmail.Text.Trim();
            if (email.Length < 10)
            {
                errorProvider1.SetError(tbEmail, "Email invalid !");
                e.Cancel = true;
            }
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEmail, null);
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            string telefon = tbTelefon.Text.Trim();
            if (telefon.Length < 10)
            {
                errorProvider1.SetError(tbTelefon, "telefon invalid !");
                e.Cancel = true;
            }
        }

        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEmail, null);
        }
    }
}
