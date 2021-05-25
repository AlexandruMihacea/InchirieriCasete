using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Entities;

namespace Proiect
{
    public partial class Form1 : Form
    {

        
        List<Filme> _filme = new List<Filme>();
        List<Clienti> _clienti = new List<Clienti>();
        List<Inchirieri> _inchirieri = new List<Inchirieri>(); 
        public Form1()
        {
            InitializeComponent();
            _inchirieri = new List<Inchirieri>();
        }

        private void btnMkRes_Click(object sender, EventArgs e)
        {
            FormMkRes frm = new FormMkRes(_filme, _clienti, _inchirieri);
            frm.ShowDialog();


        }

      
        private void btnViewRes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormMKClient formMKC = new FormMKClient(_clienti);
            formMKC.ShowDialog();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            FormMKFilm formMKF = new FormMKFilm(_filme);
            formMKF.ShowDialog();
        }
    }
}
