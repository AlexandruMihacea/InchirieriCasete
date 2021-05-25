using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proiect.Entities;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Proiect
{
    public partial class FormMKFilm : Form
    {
        private List<Filme> _filme;
        public FormMKFilm()
        {
            InitializeComponent();
            _filme = new List<Filme>();
        }

        public void DisplayFilme()
        {
            lvFilme.Items.Clear();

            foreach (Filme filme in _filme)
            {
                var listViewItem = new ListViewItem(filme.Nume);
                listViewItem.SubItems.Add(filme.Durata.ToString());

                listViewItem.Tag = filme;

                lvFilme.Items.Add(listViewItem);
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            string nume = tbNumeFilm.Text;
            string durata = tbDurataFilm.Text;

            var filme = new Filme(nume, int.Parse(durata));
            _filme.Add(filme);
            DisplayFilme();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvFilme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Film !");
                return;
            }

            ListViewItem listViewItem = lvFilme.SelectedItems[0];

            Filme filme = (Filme)listViewItem.Tag;

            EditFilm editFilme = new EditFilm(filme);
            if (editFilme.ShowDialog() == DialogResult.OK)
                DisplayFilme();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFilme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Film !");
                return;
            }

            if (MessageBox.Show(
                "Esti sigur ca vrei sa stergi clientul ?",
                "Delete client",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvFilme.SelectedItems[0];
                Filme filme = (Filme)listViewItem.Tag;
                _filme.Remove(filme);
                DisplayFilme();
            }
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {

            if (lvFilme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Film !");
                return;
            }

            if (MessageBox.Show(
                "Esti sigur ca vrei sa stergi clientul ?",
                "Delete client",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ListViewItem listViewItem = lvFilme.SelectedItems[0];
                Filme filme = (Filme)listViewItem.Tag;
                _filme.Remove(filme);
                DisplayFilme();
            }
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lvFilme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Film !");
                return;
            }

            ListViewItem listViewItem = lvFilme.SelectedItems[0];

            Filme filme = (Filme)listViewItem.Tag;

            EditFilm editFilme = new EditFilm(filme);
            if (editFilme.ShowDialog() == DialogResult.OK)
                DisplayFilme();

        }

        private void cmsExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File | *.csv";
            saveFileDialog.Title = "Export CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("\"Numele Film\", \"Durata\"");
                    foreach (Filme filme in _filme)
                    {
                        writer.WriteLine($"\"{filme.Nume}\",\"{filme.Durata}");
                    }
                }
            }
        }

        private void tbNumeFilm_Validating(object sender, CancelEventArgs e)
        {
            string user = tbNumeFilm.Text.Trim();
            if (user.Length < 2)
            {
                errorProvider1.SetError(tbNumeFilm, "Nume invalid !");
                e.Cancel = true;
            }
        }

        private void tbNumeFilm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbNumeFilm, null);
        }

        private void tbDurataFilm_Validating(object sender, CancelEventArgs e)
        {
            string user = tbDurataFilm.Text.Trim();
            if (user.Length < 2)
            {
                errorProvider1.SetError(tbDurataFilm, "Nume invalid !");
                e.Cancel = true;
            }
        }

        private void tbDurataFilm_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbDurataFilm, null);
        }

        private void tsBySer_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _filme);
            }
        }

        private void tsXMLSer_Click(object sender, EventArgs e)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Filme>));
            //using (FileStream stream = File.Create("serialized.xml"))
            //{
            //    serializer.Serialize(stream, _filme);
            //}
        }

        private void tsByDes_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _filme = (List<Filme>)formatter.Deserialize(stream);
                DisplayFilme();
            }
        }

        private void tsXMLDes_Click(object sender, EventArgs e)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
            //using (FileStream stream = File.OpenRead("serialized.xml"))
            //{
            //    _filme = (List<Filme>)serializer.Deserialize(stream);
            //    DisplayFilme();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
