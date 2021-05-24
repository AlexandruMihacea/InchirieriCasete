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
    public partial class EditFilm : Form
    {
        private Filme _filme;
        public EditFilm(Filme filme)
        {
            InitializeComponent();
            _filme = filme;
        }

        private void EditFilm_Load(object sender, EventArgs e)
        {
            tbNumeFilm.Text = _filme.Nume;
            tbDurataFilm.Text = _filme.Durata.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _filme.Nume = tbNumeFilm.Text.Trim();
            _filme.Durata = int.Parse(tbDurataFilm.Text.Trim());
        }
    }
}
