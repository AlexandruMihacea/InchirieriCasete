
namespace Proiect
{
    partial class FormMkRes
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancelOne = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbClienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lwRes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Movie";
            // 
            // cbMovie
            // 
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(486, 87);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(121, 23);
            this.cbMovie.TabIndex = 10;
            this.cbMovie.Text = "Filme";
            this.cbMovie.SelectionChangeCommitted += new System.EventHandler(this.cbMovie_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Alege un film";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cat timp";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(486, 270);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 23);
            this.tbPrice.TabIndex = 14;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(448, 459);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 16;
            this.btnReserve.Text = " Book";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancelOne
            // 
            this.btnCancelOne.Location = new System.Drawing.Point(560, 458);
            this.btnCancelOne.Name = "btnCancelOne";
            this.btnCancelOne.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOne.TabIndex = 17;
            this.btnCancelOne.Text = "Cancel";
            this.btnCancelOne.UseVisualStyleBackColor = true;
            this.btnCancelOne.Click += new System.EventHandler(this.btnCancelOne_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(486, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(11, 75);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(31, 19);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(11, 47);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(31, 19);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(11, 22);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 19);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Calculeaza pretul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbClienti
            // 
            this.cbClienti.FormattingEnabled = true;
            this.cbClienti.Location = new System.Drawing.Point(98, 86);
            this.cbClienti.Name = "cbClienti";
            this.cbClienti.Size = new System.Drawing.Size(121, 23);
            this.cbClienti.TabIndex = 20;
            this.cbClienti.Text = "Clienti";
            this.cbClienti.SelectionChangeCommitted += new System.EventHandler(this.cbClienti_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Alege un  Client";
            // 
            // lwRes
            // 
            this.lwRes.HideSelection = false;
            this.lwRes.Location = new System.Drawing.Point(30, 145);
            this.lwRes.Name = "lwRes";
            this.lwRes.Size = new System.Drawing.Size(278, 298);
            this.lwRes.TabIndex = 22;
            this.lwRes.UseCompatibleStateImageBehavior = false;
            // 
            // FormMkRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 561);
            this.Controls.Add(this.lwRes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClienti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelOne);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FormMkRes";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.FormMkRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancelOne;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbClienti;
        private System.Windows.Forms.ListView lwRes;
        private System.Windows.Forms.Label label1;
    }
}