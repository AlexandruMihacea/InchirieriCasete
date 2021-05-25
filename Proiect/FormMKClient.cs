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
using System.Data.SQLite;

namespace Proiect
{
    public partial class FormMKClient : Form
    {
        private int printIndex = 0;
        private List<Clienti> _clienti;
        private string ConnectionString = "Data Source = database.db";

        public FormMKClient(List<Clienti> clienti)
        {
            InitializeComponent();
            _clienti = clienti;
        }



        public void DisplayClienti()
        {
            lvClienti.Items.Clear();

            foreach (Clienti clienti in _clienti)
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

            //AddClienti(clienti);
            _clienti.Add(clienti);
            DisplayClienti();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Alege un Client !");
                return;
            }

            ListViewItem listViewItem = lvClienti.SelectedItems[0];
            Clienti clienti = (Clienti)listViewItem.Tag;

            EditClienti editClienti = new EditClienti(clienti);
            if (editClienti.ShowDialog() == DialogResult.OK)
            {
                //UpdateClienti(clienti);
                DisplayClienti();
            }

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
                try
                {
                    ListViewItem listViewItem = lvClienti.SelectedItems[0];
                    Clienti clienti = (Clienti)listViewItem.Tag;
                    _clienti.Remove(clienti);
                    //DeleteClienti(clienti);
                    DisplayClienti();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //private void DeleteClienti(Clienti clienti)
        //{
        //     ////string query = "DELETE FROM Clienti WHERE Id=@id";
        //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
        //    {
        //        SQLiteCommand command = new SQLiteCommand(query, connection);
        //        command.Parameters.AddWithValue("@id", clienti.Id);

        //        connection.Open();

        //        command.ExecuteNonQuery();

        //        _clienti.Remove(clienti);
        //    }
        //}


        private void btnSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = System.IO.File.Create("serialized.bin"))
            {
                formatter.Serialize(stream, _clienti);
            }

        }


        private void btnDeserializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = System.IO.File.OpenRead("serialized.bin"))
            {
                _clienti = (List<Clienti>)formatter.Deserialize(stream);
                DisplayClienti();
            }
        }



        private void btnXMLSerializare_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
            using (FileStream stream = System.IO.File.Create("serialized.xml"))
            {
                serializer.Serialize(stream, _clienti);
            }
        }


        private void btnXMLDeserializare_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Clienti>));
            using (FileStream stream = System.IO.File.OpenRead("serialized.xml"))
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
                using (StreamWriter writer = System.IO.File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("\"Numele\", \"Prenumele\", \"Email\", \"Telefon\"");
                    foreach (Clienti clienti in _clienti)
                    {
                        writer.WriteLine($"\"{clienti.LastName}\",\"{clienti.FirstName}\",{clienti.Email}\",\"{clienti.Telefon}");
                    }
                }
            }
        }



        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            string nume = tbNume.Text.Trim();
            if (nume.Length < 3)
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

        private void cmsDelete_Click(object sender, EventArgs e)
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

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lvClienti.SelectedItems.Count == 0)
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

        private void cmsExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File | *.csv";
            saveFileDialog.Title = "Export CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = System.IO.File.CreateText(saveFileDialog.FileName))
                {
                    writer.WriteLine("\"Numele\", \"Prenumele\", \"Email\", \"Telefon\"");
                    foreach (Clienti clienti in _clienti)
                    {
                        writer.WriteLine($"\"{clienti.LastName}\",\"{clienti.FirstName}\",{clienti.Email}\",\"{clienti.Telefon}");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pageSetupDialog_HelpRequest(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Times New Roman", 18);
            var pageSettings = e.PageSettings;

            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;

            var marginLeft = e.MarginBounds.Left;
            var marginTop = e.MarginBounds.Top;

            int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            var currentY = marginTop;

            while (printIndex < _clienti.Count)
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    _clienti[printIndex].LastName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY
                    );

                currentX += columnWidth;
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    _clienti[printIndex].FirstName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight));

                currentY += rowHeight;

                printIndex++;

                if (currentY - marginTop + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }






            //private void AddClienti(Clienti clienti)
            //{
            //    string query = "INSERT INTO Clienti(LastName, FirstName, Email, Telefon) VALUES(@lastName, @fisrtName, @Email, @Telefon); SELECT last_insert_rowid()";
            //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            //    {
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@lastName", clienti.LastName);
            //        command.Parameters.AddWithValue("@firstName", clienti.FirstName);
            //        command.Parameters.AddWithValue("@Email", clienti.Email);
            //        command.Parameters.AddWithValue("@Telefon", clienti.Telefon);

            //        connection.Open();


            //        _clienti.Add(clienti);

            //    }
            //}

            //private void UpdateClienti(Clienti clienti)
            //{
            //    string query = "UPDATE Clienti SET LastName = @lastName, FirstName = @firstName, Email = @Email, Telefon = @Telefon WHERE Id = @id";

            //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            //    {
            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        command.Parameters.AddWithValue("@lastName", clienti.LastName);
            //        command.Parameters.AddWithValue("@firstName", clienti.FirstName);
            //        command.Parameters.AddWithValue("@Email", clienti.Email);
            //        command.Parameters.AddWithValue("@Telefon", clienti.Telefon);

            //        connection.Open();

            //        command.ExecuteNonQuery();
            //    }
            //}

            //private void LoadClienti()
            //{
            //    string query = "SELECT * FROM Clienti";
            //    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            //    {


            //        SQLiteCommand command = new SQLiteCommand(query, connection);
            //        connection.Open();

            //        using (SQLiteDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                long id = (long)reader["Id"];
            //                string lastName = (string)reader["LastName"];
            //                string firstName = (string)reader["FirstName"];
            //                string Telefon = (string)reader["Telefon"];
            //                string Email = (string)reader["Email"];


            //                Clienti clienti = new Clienti(id,lastName, firstName, int.Parse(Telefon), Email); ;
            //                _clienti.Add(clienti);
            //            }
            //        }
            //    }
            //}


            //private void FormMKClient_Load(object sender, EventArgs e)
            //{
            //    LoadClienti();
            //    DisplayClienti();
            //}
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
          if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void btnPrintPrview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }



    }
}
