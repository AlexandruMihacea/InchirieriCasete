
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
            this.btnMkRes = new System.Windows.Forms.Button();
            this.btnEditRes = new System.Windows.Forms.Button();
            this.btnDelRes = new System.Windows.Forms.Button();
            this.lwAfisare = new System.Windows.Forms.ListView();
            this.btnViewRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMkRes
            // 
            this.btnMkRes.Location = new System.Drawing.Point(13, 111);
            this.btnMkRes.Name = "btnMkRes";
            this.btnMkRes.Size = new System.Drawing.Size(110, 23);
            this.btnMkRes.TabIndex = 0;
            this.btnMkRes.Text = "Make Reservation";
            this.btnMkRes.UseVisualStyleBackColor = true;
            this.btnMkRes.Click += new System.EventHandler(this.btnMkRes_Click);
            // 
            // btnEditRes
            // 
            this.btnEditRes.Location = new System.Drawing.Point(12, 373);
            this.btnEditRes.Name = "btnEditRes";
            this.btnEditRes.Size = new System.Drawing.Size(110, 23);
            this.btnEditRes.TabIndex = 1;
            this.btnEditRes.Text = "Edit Reservation";
            this.btnEditRes.UseVisualStyleBackColor = true;
            // 
            // btnDelRes
            // 
            this.btnDelRes.Location = new System.Drawing.Point(12, 418);
            this.btnDelRes.Name = "btnDelRes";
            this.btnDelRes.Size = new System.Drawing.Size(110, 23);
            this.btnDelRes.TabIndex = 2;
            this.btnDelRes.Text = "Delete Reservation";
            this.btnDelRes.UseVisualStyleBackColor = true;
            // 
            // lwAfisare
            // 
            this.lwAfisare.HideSelection = false;
            this.lwAfisare.Location = new System.Drawing.Point(177, 111);
            this.lwAfisare.Name = "lwAfisare";
            this.lwAfisare.Size = new System.Drawing.Size(355, 330);
            this.lwAfisare.TabIndex = 3;
            this.lwAfisare.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewRes
            // 
            this.btnViewRes.Location = new System.Drawing.Point(13, 161);
            this.btnViewRes.Name = "btnViewRes";
            this.btnViewRes.Size = new System.Drawing.Size(110, 23);
            this.btnViewRes.TabIndex = 4;
            this.btnViewRes.Text = "View Reservation";
            this.btnViewRes.UseVisualStyleBackColor = true;
            this.btnViewRes.Click += new System.EventHandler(this.btnViewRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 599);
            this.Controls.Add(this.btnViewRes);
            this.Controls.Add(this.lwAfisare);
            this.Controls.Add(this.btnDelRes);
            this.Controls.Add(this.btnEditRes);
            this.Controls.Add(this.btnMkRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMkRes;
        private System.Windows.Forms.Button btnEditRes;
        private System.Windows.Forms.Button btnDelRes;
        private System.Windows.Forms.ListView lwAfisare;
        private System.Windows.Forms.Button btnViewRes;
    }
}

