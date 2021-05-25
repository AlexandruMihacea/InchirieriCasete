
namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMkRes = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMkRes
            // 
            this.btnMkRes.Image = ((System.Drawing.Image)(resources.GetObject("btnMkRes.Image")));
            this.btnMkRes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMkRes.Location = new System.Drawing.Point(195, 75);
            this.btnMkRes.Name = "btnMkRes";
            this.btnMkRes.Size = new System.Drawing.Size(144, 53);
            this.btnMkRes.TabIndex = 0;
            this.btnMkRes.Text = "Make Reservation";
            this.btnMkRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMkRes.UseVisualStyleBackColor = true;
            this.btnMkRes.Click += new System.EventHandler(this.btnMkRes_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddClient.Location = new System.Drawing.Point(12, 29);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(110, 41);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "AddClient";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFilm.Image")));
            this.btnAddFilm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFilm.Location = new System.Drawing.Point(12, 145);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(110, 42);
            this.btnAddFilm.TabIndex = 6;
            this.btnAddFilm.Text = "Add Film";
            this.btnAddFilm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 228);
            this.Controls.Add(this.btnAddFilm);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnMkRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMkRes;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddFilm;
    }
}

