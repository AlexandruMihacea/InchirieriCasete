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
    }
}
