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
    public partial class EditClienti : Form
    {
        private Clienti _client;
        public EditClienti(Clienti client)
        {
            InitializeComponent();
            _client = client;
        }

        private void EditClienti_Load(object sender, EventArgs e)
        {
            tbNumeEdit.Text = _client.LastName;
            tbPrenumeEdit.Text = _client.FirstName;
            tbEmailEdit.Text = _client.Email;
            tbTelefonEdit.Text =_client.Telefon.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _client.LastName = tbNumeEdit.Text.Trim();
            _client.FirstName = tbPrenumeEdit.Text.Trim();
            _client.Email = tbEmailEdit.Text.Trim();
            _client.Telefon = int.Parse(tbTelefonEdit.Text.Trim());

        }
    }
}
