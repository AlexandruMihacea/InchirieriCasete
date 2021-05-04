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

        List<Inchirieri> _lista = new List<Inchirieri>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMkRes_Click(object sender, EventArgs e)
        {
            FormMkRes frm = new FormMkRes();
            frm.ShowDialog();

        }



        private void btnViewRes_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
