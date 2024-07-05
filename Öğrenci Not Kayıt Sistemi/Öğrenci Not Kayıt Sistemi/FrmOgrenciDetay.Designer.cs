namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgrenciDetay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblNumara = new System.Windows.Forms.Label();
            this.LblSınav1 = new System.Windows.Forms.Label();
            this.LblSınav2 = new System.Windows.Forms.Label();
            this.LblSınav3 = new System.Windows.Forms.Label();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.LblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numarası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ortalama :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Durum :";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(139, 23);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(41, 16);
            this.LblAdSoyad.TabIndex = 7;
            this.LblAdSoyad.Text = "NULL";
            this.LblAdSoyad.Click += new System.EventHandler(this.label8_Click);
            // 
            // LblNumara
            // 
            this.LblNumara.AutoSize = true;
            this.LblNumara.Location = new System.Drawing.Point(139, 55);
            this.LblNumara.Name = "LblNumara";
            this.LblNumara.Size = new System.Drawing.Size(21, 16);
            this.LblNumara.TabIndex = 8;
            this.LblNumara.Text = "00";
            // 
            // LblSınav1
            // 
            this.LblSınav1.AutoSize = true;
            this.LblSınav1.Location = new System.Drawing.Point(109, 121);
            this.LblSınav1.Name = "LblSınav1";
            this.LblSınav1.Size = new System.Drawing.Size(21, 16);
            this.LblSınav1.TabIndex = 9;
            this.LblSınav1.Text = "00";
            // 
            // LblSınav2
            // 
            this.LblSınav2.AutoSize = true;
            this.LblSınav2.Location = new System.Drawing.Point(109, 159);
            this.LblSınav2.Name = "LblSınav2";
            this.LblSınav2.Size = new System.Drawing.Size(21, 16);
            this.LblSınav2.TabIndex = 10;
            this.LblSınav2.Text = "00";
            // 
            // LblSınav3
            // 
            this.LblSınav3.AutoSize = true;
            this.LblSınav3.Location = new System.Drawing.Point(109, 195);
            this.LblSınav3.Name = "LblSınav3";
            this.LblSınav3.Size = new System.Drawing.Size(21, 16);
            this.LblSınav3.TabIndex = 11;
            this.LblSınav3.Text = "00";
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Location = new System.Drawing.Point(109, 230);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(21, 16);
            this.LblOrtalama.TabIndex = 12;
            this.LblOrtalama.Text = "00";

            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Location = new System.Drawing.Point(104, 274);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(41, 16);
            this.LblDurum.TabIndex = 13;
            this.LblDurum.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 355);
            this.Controls.Add(this.LblDurum);
            this.Controls.Add(this.LblOrtalama);
            this.Controls.Add(this.LblSınav3);
            this.Controls.Add(this.LblSınav2);
            this.Controls.Add(this.LblSınav1);
            this.Controls.Add(this.LblNumara);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOgrenciDetay";
            this.Text = "FrmOgrenciDetay";
            this.Load += new System.EventHandler(this.FrmOgrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblNumara;
        private System.Windows.Forms.Label LblSınav1;
        private System.Windows.Forms.Label LblSınav2;
        private System.Windows.Forms.Label LblSınav3;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.Label LblDurum;
    }
}