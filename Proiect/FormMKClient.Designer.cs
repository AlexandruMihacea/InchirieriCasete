
namespace Proiect
{
    partial class FormMKClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMKClient));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvClienti = new System.Windows.Forms.ListView();
            this.Nume = new System.Windows.Forms.ColumnHeader();
            this.Prenume = new System.Windows.Forms.ColumnHeader();
            this.Email = new System.Windows.Forms.ColumnHeader();
            this.Telefon = new System.Windows.Forms.ColumnHeader();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Binary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.XML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXMLSerializare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXMLDeserializare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPrview = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExport = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Client";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(89, 365);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 23);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "&Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(80, 87);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 23);
            this.tbNume.TabIndex = 5;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(80, 151);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 23);
            this.tbPrenume.TabIndex = 6;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(80, 218);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 23);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(80, 287);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 23);
            this.tbTelefon.TabIndex = 8;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefon";
            // 
            // lvClienti
            // 
            this.lvClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Email,
            this.Telefon});
            this.lvClienti.FullRowSelect = true;
            this.lvClienti.GridLines = true;
            this.lvClienti.HideSelection = false;
            this.lvClienti.Location = new System.Drawing.Point(358, 78);
            this.lvClienti.Name = "lvClienti";
            this.lvClienti.Size = new System.Drawing.Size(392, 231);
            this.lvClienti.TabIndex = 53;
            this.lvClienti.UseCompatibleStateImageBehavior = false;
            this.lvClienti.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 100;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 100;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 100;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(601, 374);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(705, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Binary,
            this.XML,
            this.btnStrip,
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Binary
            // 
            this.Binary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeBinary,
            this.btnDeserializeBinary});
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(52, 20);
            this.Binary.Text = "Binary";
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(150, 22);
            this.btnSerializeBinary.Text = "Serialization";
            this.btnSerializeBinary.Click += new System.EventHandler(this.btnSerializeBinary_Click);
            // 
            // btnDeserializeBinary
            // 
            this.btnDeserializeBinary.Name = "btnDeserializeBinary";
            this.btnDeserializeBinary.Size = new System.Drawing.Size(150, 22);
            this.btnDeserializeBinary.Text = "Deserialization";
            this.btnDeserializeBinary.Click += new System.EventHandler(this.btnDeserializeBinary_Click);
            // 
            // XML
            // 
            this.XML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXMLSerializare,
            this.btnXMLDeserializare});
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(43, 20);
            this.XML.Text = "XML";
            // 
            // btnXMLSerializare
            // 
            this.btnXMLSerializare.Name = "btnXMLSerializare";
            this.btnXMLSerializare.Size = new System.Drawing.Size(166, 22);
            this.btnXMLSerializare.Text = "XML Serializare";
            this.btnXMLSerializare.Click += new System.EventHandler(this.btnXMLSerializare_Click);
            // 
            // btnXMLDeserializare
            // 
            this.btnXMLDeserializare.Name = "btnXMLDeserializare";
            this.btnXMLDeserializare.Size = new System.Drawing.Size(166, 22);
            this.btnXMLDeserializare.Text = "XML Deserializare";
            this.btnXMLDeserializare.Click += new System.EventHandler(this.btnXMLDeserializare_Click);
            // 
            // btnStrip
            // 
            this.btnStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport});
            this.btnStrip.Name = "btnStrip";
            this.btnStrip.Size = new System.Drawing.Size(53, 20);
            this.btnStrip.Text = "Export";
            // 
            // btnExport
            // 
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(108, 22);
            this.btnExport.Text = "&Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnPrintPrview});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(143, 22);
            this.btnPrint.Text = "btnPrint";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPrview
            // 
            this.btnPrintPrview.Name = "btnPrintPrview";
            this.btnPrintPrview.Size = new System.Drawing.Size(143, 22);
            this.btnPrintPrview.Text = "tsPrintPrview";
            this.btnPrintPrview.Click += new System.EventHandler(this.btnPrintPrview_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            this.pageSetupDialog.HelpRequest += new System.EventHandler(this.pageSetupDialog_HelpRequest);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FormMKClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvClienti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMKClient";
            this.Text = "FormMKClient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvClienti;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Binary;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem XML;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnXMLSerializare;
        private System.Windows.Forms.ToolStripMenuItem btnXMLDeserializare;
        private System.Windows.Forms.ToolStripMenuItem btnStrip;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsExport;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.ToolStripMenuItem tsPrint;
        private System.Windows.Forms.ToolStripMenuItem tsPrintPrview;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPrview;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}