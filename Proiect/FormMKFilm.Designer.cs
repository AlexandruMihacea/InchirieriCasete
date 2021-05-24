
namespace Proiect
{
    partial class FormMKFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumeFilm = new System.Windows.Forms.TextBox();
            this.tbDurataFilm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvFilme = new System.Windows.Forms.ListView();
            this.Film = new System.Windows.Forms.ColumnHeader();
            this.Durata = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Film";
            // 
            // tbNumeFilm
            // 
            this.tbNumeFilm.Location = new System.Drawing.Point(79, 70);
            this.tbNumeFilm.Name = "tbNumeFilm";
            this.tbNumeFilm.Size = new System.Drawing.Size(100, 23);
            this.tbNumeFilm.TabIndex = 1;
            // 
            // tbDurataFilm
            // 
            this.tbDurataFilm.Location = new System.Drawing.Point(79, 136);
            this.tbDurataFilm.Name = "tbDurataFilm";
            this.tbDurataFilm.Size = new System.Drawing.Size(100, 23);
            this.tbDurataFilm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nume Film ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durata Film";
            // 
            // lvFilme
            // 
            this.lvFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Film,
            this.Durata});
            this.lvFilme.FullRowSelect = true;
            this.lvFilme.GridLines = true;
            this.lvFilme.HideSelection = false;
            this.lvFilme.Location = new System.Drawing.Point(264, 49);
            this.lvFilme.Name = "lvFilme";
            this.lvFilme.Size = new System.Drawing.Size(324, 175);
            this.lvFilme.TabIndex = 5;
            this.lvFilme.UseCompatibleStateImageBehavior = false;
            this.lvFilme.View = System.Windows.Forms.View.Details;
            // 
            // Film
            // 
            this.Film.Width = 175;
            // 
            // Durata
            // 
            this.Durata.Width = 175;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(27, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(136, 232);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilm.TabIndex = 7;
            this.btnAddFilm.Text = "Add";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(496, 232);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormMKFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 291);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDurataFilm);
            this.Controls.Add(this.tbNumeFilm);
            this.Controls.Add(this.label1);
            this.Name = "FormMKFilm";
            this.Text = "FormMKFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumeFilm;
        private System.Windows.Forms.TextBox tbDurataFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvFilme;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.ColumnHeader Film;
        private System.Windows.Forms.ColumnHeader Durata;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}