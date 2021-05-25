
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMKFilm));
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBySer = new System.Windows.Forms.ToolStripButton();
            this.tsXMLSer = new System.Windows.Forms.ToolStripButton();
            this.tsByDes = new System.Windows.Forms.ToolStripButton();
            this.tsXMLDes = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.tbNumeFilm.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeFilm_Validating);
            this.tbNumeFilm.Validated += new System.EventHandler(this.tbNumeFilm_Validated);
            // 
            // tbDurataFilm
            // 
            this.tbDurataFilm.Location = new System.Drawing.Point(79, 136);
            this.tbDurataFilm.Name = "tbDurataFilm";
            this.tbDurataFilm.Size = new System.Drawing.Size(100, 23);
            this.tbDurataFilm.TabIndex = 2;
            this.tbDurataFilm.Validating += new System.ComponentModel.CancelEventHandler(this.tbDurataFilm_Validating);
            this.tbDurataFilm.Validated += new System.EventHandler(this.tbDurataFilm_Validated);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(136, 232);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(75, 23);
            this.btnAddFilm.TabIndex = 7;
            this.btnAddFilm.Text = "&Add";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEdit,
            this.cmsDelete,
            this.cmsExport});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 70);
            // 
            // cmsEdit
            // 
            this.cmsEdit.Name = "cmsEdit";
            this.cmsEdit.Size = new System.Drawing.Size(108, 22);
            this.cmsEdit.Text = "Edit";
            this.cmsEdit.Click += new System.EventHandler(this.cmsEdit_Click);
            // 
            // cmsDelete
            // 
            this.cmsDelete.Name = "cmsDelete";
            this.cmsDelete.Size = new System.Drawing.Size(108, 22);
            this.cmsDelete.Text = "Delete";
            this.cmsDelete.Click += new System.EventHandler(this.cmsDelete_Click);
            // 
            // cmsExport
            // 
            this.cmsExport.Name = "cmsExport";
            this.cmsExport.Size = new System.Drawing.Size(108, 22);
            this.cmsExport.Text = "Export";
            this.cmsExport.Click += new System.EventHandler(this.cmsExport_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBySer,
            this.tsXMLSer,
            this.tsByDes,
            this.tsXMLDes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBySer
            // 
            this.tsBySer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBySer.Image = ((System.Drawing.Image)(resources.GetObject("tsBySer.Image")));
            this.tsBySer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBySer.Name = "tsBySer";
            this.tsBySer.Size = new System.Drawing.Size(23, 22);
            this.tsBySer.Text = "Binary Serializare";
            this.tsBySer.Click += new System.EventHandler(this.tsBySer_Click);
            // 
            // tsXMLSer
            // 
            this.tsXMLSer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsXMLSer.Image = ((System.Drawing.Image)(resources.GetObject("tsXMLSer.Image")));
            this.tsXMLSer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXMLSer.Name = "tsXMLSer";
            this.tsXMLSer.Size = new System.Drawing.Size(23, 22);
            this.tsXMLSer.Text = "XML Serializare";
            this.tsXMLSer.Click += new System.EventHandler(this.tsXMLSer_Click);
            // 
            // tsByDes
            // 
            this.tsByDes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsByDes.Image = ((System.Drawing.Image)(resources.GetObject("tsByDes.Image")));
            this.tsByDes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsByDes.Name = "tsByDes";
            this.tsByDes.Size = new System.Drawing.Size(23, 22);
            this.tsByDes.Text = "Binary Deserializare";
            this.tsByDes.Click += new System.EventHandler(this.tsByDes_Click);
            // 
            // tsXMLDes
            // 
            this.tsXMLDes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsXMLDes.Image = ((System.Drawing.Image)(resources.GetObject("tsXMLDes.Image")));
            this.tsXMLDes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXMLDes.Name = "tsXMLDes";
            this.tsXMLDes.Size = new System.Drawing.Size(23, 22);
            this.tsXMLDes.Text = "XML Deserializare";
            this.tsXMLDes.Click += new System.EventHandler(this.tsXMLDes_Click);
            // 
            // FormMKFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 291);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsExport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBySer;
        private System.Windows.Forms.ToolStripButton tsXMLSer;
        private System.Windows.Forms.ToolStripButton tsByDes;
        private System.Windows.Forms.ToolStripButton tsXMLDes;
    }
}