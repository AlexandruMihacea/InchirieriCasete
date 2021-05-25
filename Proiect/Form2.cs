using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = tbUser.Text;
            pass = tbPass.Text;
            if(user == "admin" && pass == "admin")
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUser_Validating(object sender, CancelEventArgs e)
        {
            string user = tbUser.Text.Trim();
            if (user.Length < 3)
            {
                errorProvider1.SetError(tbUser, "User invalid !");
                e.Cancel = true;
            }
        }

        private void tbUser_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbUser, null);
        }

        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            string pass = tbPass.Text.Trim();
            if (pass.Length < 3)
            {
                errorProvider1.SetError(tbPass, "Pass invalid !");
                e.Cancel = true;
            }
        }

        private void tbPass_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPass, null);
        }
    }
}
