namespace SinemaBiletSatis
{
    partial class biletDegisiklikForm
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
            this.kadSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.biletSil = new System.Windows.Forms.Button();
            this.mAd = new System.Windows.Forms.TextBox();
            this.mSoyad = new System.Windows.Forms.TextBox();
            this.rezerveSil = new System.Windows.Forms.Button();
            this.biletListele = new System.Windows.Forms.Button();
            this.rezerveSat = new System.Windows.Forms.Button();
            this.odemeComb = new System.Windows.Forms.ComboBox();
            this.ucretComb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rezervesonsat = new System.Windows.Forms.Button();
            this.don = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kadSoyad
            // 
            this.kadSoyad.AutoSize = true;
            this.kadSoyad.Location = new System.Drawing.Point(17, 16);
            this.kadSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kadSoyad.Name = "kadSoyad";
            this.kadSoyad.Size = new System.Drawing.Size(24, 17);
            this.kadSoyad.TabIndex = 0;
            this.kadSoyad.Text = "ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seyirci Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seyirci Soyad :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(959, 374);
            this.dataGridView1.TabIndex = 3;
            // 
            // biletSil
            // 
            this.biletSil.Location = new System.Drawing.Point(35, 181);
            this.biletSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.biletSil.Name = "biletSil";
            this.biletSil.Size = new System.Drawing.Size(235, 28);
            this.biletSil.TabIndex = 4;
            this.biletSil.Text = "Bilet İptal  Et";
            this.biletSil.UseVisualStyleBackColor = true;
            this.biletSil.Visible = false;
            this.biletSil.Click += new System.EventHandler(this.biletSil_Click);
            // 
            // mAd
            // 
            this.mAd.Location = new System.Drawing.Point(136, 50);
            this.mAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAd.Name = "mAd";
            this.mAd.Size = new System.Drawing.Size(132, 22);
            this.mAd.TabIndex = 5;
            // 
            // mSoyad
            // 
            this.mSoyad.Location = new System.Drawing.Point(136, 82);
            this.mSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mSoyad.Name = "mSoyad";
            this.mSoyad.Size = new System.Drawing.Size(132, 22);
            this.mSoyad.TabIndex = 6;
            // 
            // rezerveSil
            // 
            this.rezerveSil.Location = new System.Drawing.Point(35, 234);
            this.rezerveSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rezerveSil.Name = "rezerveSil";
            this.rezerveSil.Size = new System.Drawing.Size(235, 28);
            this.rezerveSil.TabIndex = 7;
            this.rezerveSil.Text = "Rezerve İptal Et";
            this.rezerveSil.UseVisualStyleBackColor = true;
            this.rezerveSil.Visible = false;
            this.rezerveSil.Click += new System.EventHandler(this.rezerveSil_Click);
            // 
            // biletListele
            // 
            this.biletListele.Location = new System.Drawing.Point(35, 130);
            this.biletListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.biletListele.Name = "biletListele";
            this.biletListele.Size = new System.Drawing.Size(235, 28);
            this.biletListele.TabIndex = 8;
            this.biletListele.Text = "Bilet Ara";
            this.biletListele.UseVisualStyleBackColor = true;
            this.biletListele.Click += new System.EventHandler(this.biletListele_Click);
            // 
            // rezerveSat
            // 
            this.rezerveSat.Location = new System.Drawing.Point(35, 287);
            this.rezerveSat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rezerveSat.Name = "rezerveSat";
            this.rezerveSat.Size = new System.Drawing.Size(235, 28);
            this.rezerveSat.TabIndex = 9;
            this.rezerveSat.Text = "Rezerve Sat";
            this.rezerveSat.UseVisualStyleBackColor = true;
            this.rezerveSat.Visible = false;
            this.rezerveSat.Click += new System.EventHandler(this.rezerveSat_Click);
            // 
            // odemeComb
            // 
            this.odemeComb.FormattingEnabled = true;
            this.odemeComb.Location = new System.Drawing.Point(136, 399);
            this.odemeComb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.odemeComb.Name = "odemeComb";
            this.odemeComb.Size = new System.Drawing.Size(132, 24);
            this.odemeComb.TabIndex = 10;
            this.odemeComb.Visible = false;
            // 
            // ucretComb
            // 
            this.ucretComb.FormattingEnabled = true;
            this.ucretComb.Location = new System.Drawing.Point(136, 348);
            this.ucretComb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucretComb.Name = "ucretComb";
            this.ucretComb.Size = new System.Drawing.Size(132, 24);
            this.ucretComb.TabIndex = 11;
            this.ucretComb.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ucret Türü :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Odeme  Türü :";
            this.label4.Visible = false;
            // 
            // rezervesonsat
            // 
            this.rezervesonsat.Location = new System.Drawing.Point(23, 454);
            this.rezervesonsat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rezervesonsat.Name = "rezervesonsat";
            this.rezervesonsat.Size = new System.Drawing.Size(247, 34);
            this.rezervesonsat.TabIndex = 14;
            this.rezervesonsat.Text = "Rezerve Satma İşlemini Onaylama";
            this.rezervesonsat.UseVisualStyleBackColor = true;
            this.rezervesonsat.Click += new System.EventHandler(this.rezervesonsat_Click);
            // 
            // don
            // 
            this.don.Location = new System.Drawing.Point(1124, 460);
            this.don.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.don.Name = "don";
            this.don.Size = new System.Drawing.Size(161, 28);
            this.don.TabIndex = 15;
            this.don.Text = "Ana Sayfaya Dön";
            this.don.UseVisualStyleBackColor = true;
            this.don.Click += new System.EventHandler(this.don_Click);
            // 
            // biletDegisiklikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(157)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1309, 503);
            this.Controls.Add(this.don);
            this.Controls.Add(this.rezervesonsat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ucretComb);
            this.Controls.Add(this.odemeComb);
            this.Controls.Add(this.rezerveSat);
            this.Controls.Add(this.biletListele);
            this.Controls.Add(this.rezerveSil);
            this.Controls.Add(this.mSoyad);
            this.Controls.Add(this.mAd);
            this.Controls.Add(this.biletSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kadSoyad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "biletDegisiklikForm";
            this.Text = "rezerveSat";
            this.Load += new System.EventHandler(this.rezerveSat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kadSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button biletSil;
        private System.Windows.Forms.TextBox mAd;
        private System.Windows.Forms.TextBox mSoyad;
        private System.Windows.Forms.Button rezerveSil;
        private System.Windows.Forms.Button biletListele;
        private System.Windows.Forms.Button rezerveSat;
        private System.Windows.Forms.ComboBox odemeComb;
        private System.Windows.Forms.ComboBox ucretComb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rezervesonsat;
        private System.Windows.Forms.Button don;
    }
}