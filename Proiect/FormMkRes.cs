using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proiect.Entities;

namespace Proiect
{
    public partial class FormMkRes : Form
    {
        List<Filme> _filme;
        List<Clienti> _clienti;
        List<Inchirieri> _inchirieri;
        int Time = 0;
        int Price = 0;
        //List<Inchirieri> listaRezervari = new List<Inchirieri>();
        public FormMkRes(List<Filme> filme, List<Clienti> clienti, List<Inchirieri> inchirieri)
        {
            InitializeComponent();
            _filme = filme;
            _clienti = clienti;
            _inchirieri = inchirieri;
        }


        //public void DisplayRezervari()
        //{
        //    lwRes.Items.Clear();

        //    foreach (Inchirieri inchirieri in _inchirieri)
        //    {
        //        var listViewItem = new ListViewItem(inchirieri.pre);
        //        listViewItem.SubItems.Add(inchirieri.);
        //        listViewItem.SubItems.Add(inchirieri.);


        //        listViewItem.Tag = inchirieri;

        //        lwRes.Items.Add(listViewItem);
        //    }
        //}



        private void btnReserve_Click(object sender, EventArgs e)
        {
           
                try
              { 

                string Movie = this.cbMovie.SelectedItem.ToString();
                string clientOne = this.cbClienti.SelectedItem.ToString();
                Clienti c = new Clienti(clientOne);

                if (rb1.Checked == false && rb2.Checked == false && rb3.Checked == false)
                        MessageBox.Show("Selectati timpul de inchiriere!");
                    else
                        if (rb1.Checked)
                    {
                        Time = 1;
                        Price = 5;

                    }
                    else
                        if (rb1.Checked)
                    {
                        Time = 2;
                        Price = 7;

                    }
                    else
                        if (rb3.Checked)
                    {
                        Time = 3;
                        Price = 10;

                    }
                Filme f = new Filme(Movie);
                Inchirieri inchirieri = new Inchirieri(f, c, Price);
                _inchirieri.Add(inchirieri);

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    errorProvider1.Clear();
                }
                this.Close();


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb1.Checked == false && rb2.Checked == false && rb3.Checked == false)
                    MessageBox.Show("Selectati timpul de inchiriere!");
                else
                          if (rb1.Checked)
                {
                    Time = 1;
                    Price = 5;
                    tbPrice.Text = Price.ToString();
                }
                else
                          if (rb2.Checked)
                {
                    Time = 2;
                    Price = 7;
                    tbPrice.Text = Price.ToString();
                }
                else
                          if (rb3.Checked)
                {
                    Time = 3;
                    Price = 10;
                    tbPrice.Text = Price.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void btnCancelOne_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbMovie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filme filme = cbMovie.SelectedItem as Filme;
            
        }

        private void FormMkRes_Load(object sender, EventArgs e)
        {
            cbMovie.DataSource = _filme;
            cbMovie.ValueMember = "Durata";
            cbMovie.DisplayMember = "Nume";

            cbClienti.DataSource = _clienti;
            cbClienti.ValueMember = "FirstName";
           
        }

        private void cbClienti_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Clienti clienti = cbClienti.SelectedItem as Clienti;
        }
    }
}
