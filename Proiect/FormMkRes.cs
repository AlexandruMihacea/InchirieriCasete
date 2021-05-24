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
        int Time = 0;
        int Price = 0;
        List<Inchirieri> listaRezervari = new List<Inchirieri>();
        public FormMkRes()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if(tbFName.Text == "")
                errorProvider1.SetError(tbFName, "Introduceti Prenumele!");
            else 
                if(tbLName.Text == "")
                errorProvider1.SetError(tbLName, "Introduceti Numele!");
            else 
                if(tbEmail.Text == "")
                errorProvider1.SetError(tbEmail, "Introduceti Email!");
            else
                if(tbAge.Text == "")
                errorProvider1.SetError(tbAge, "Introduceti Varsta!");
            else
            {
                try {
                    string FirstName = tbFName.Text;
                    string LastName = tbLName.Text;
                    string Email = tbEmail.Text;
                    int Age = Convert.ToInt32(tbAge.Text);

                    Clienti c = new Clienti(FirstName, LastName,Age, Email);

                    string Movie = this.cbMovie.SelectedItem.ToString();

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
                    //Filme f = new Filme(Movie);
                    //Inchirieri I = new Inchirieri(Time, f, c, Price);
                   // listaRezervari.Add(I);

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (rb1.Checked == false && rb2.Checked == false && rb3.Checked == false)
            //        MessageBox.Show("Selectati timpul de inchiriere!");
            //    else
            //              if (rb1.Checked)
            //    {
            //        Time = 1;
            //        Price = 5;
            //        tbPrice.Text = Price.ToString();
            //    }
            //    else
            //              if (rb2.Checked)
            //    {
            //        Time = 2;
            //        Price = 7;
            //        tbPrice.Text = Price.ToString();
            //    }
            //    else
            //              if (rb3.Checked)
            //    {
            //        Time = 3;
            //        Price = 10;
            //        tbPrice.Text = Price.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            

        }

        private void btnCancelOne_Click(object sender, EventArgs e)
        {

        }
    }
}
