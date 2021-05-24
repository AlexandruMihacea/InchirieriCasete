
namespace Proiect
{
    partial class EditClienti
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
            this.tbNumeEdit = new System.Windows.Forms.TextBox();
            this.tbPrenumeEdit = new System.Windows.Forms.TextBox();
            this.tbEmailEdit = new System.Windows.Forms.TextBox();
            this.tbTelefonEdit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumeEdit
            // 
            this.tbNumeEdit.Location = new System.Drawing.Point(133, 44);
            this.tbNumeEdit.Name = "tbNumeEdit";
            this.tbNumeEdit.Size = new System.Drawing.Size(100, 23);
            this.tbNumeEdit.TabIndex = 0;
            // 
            // tbPrenumeEdit
            // 
            this.tbPrenumeEdit.Location = new System.Drawing.Point(133, 97);
            this.tbPrenumeEdit.Name = "tbPrenumeEdit";
            this.tbPrenumeEdit.Size = new System.Drawing.Size(100, 23);
            this.tbPrenumeEdit.TabIndex = 1;
            // 
            // tbEmailEdit
            // 
            this.tbEmailEdit.Location = new System.Drawing.Point(133, 152);
            this.tbEmailEdit.Name = "tbEmailEdit";
            this.tbEmailEdit.Size = new System.Drawing.Size(100, 23);
            this.tbEmailEdit.TabIndex = 2;
            // 
            // tbTelefonEdit
            // 
            this.tbTelefonEdit.Location = new System.Drawing.Point(133, 214);
            this.tbTelefonEdit.Name = "tbTelefonEdit";
            this.tbTelefonEdit.Size = new System.Drawing.Size(100, 23);
            this.tbTelefonEdit.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(70, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(202, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // EditClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 367);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbTelefonEdit);
            this.Controls.Add(this.tbEmailEdit);
            this.Controls.Add(this.tbPrenumeEdit);
            this.Controls.Add(this.tbNumeEdit);
            this.Name = "EditClienti";
            this.Text = "EditClienti";
            this.Load += new System.EventHandler(this.EditClienti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeEdit;
        private System.Windows.Forms.TextBox tbPrenumeEdit;
        private System.Windows.Forms.TextBox tbEmailEdit;
        private System.Windows.Forms.TextBox tbTelefonEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}