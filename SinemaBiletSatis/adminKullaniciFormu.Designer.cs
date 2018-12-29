namespace SinemaBiletSatis
{
    partial class adminKullaniciFormu
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
            this.kullaniciTc = new System.Windows.Forms.TextBox();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelKAd = new System.Windows.Forms.Label();
            this.kullaniciAd = new System.Windows.Forms.TextBox();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.kullaniciSoyad = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.kullaniciEmail = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.kullaniciParola = new System.Windows.Forms.TextBox();
            this.buttonKullaniciEkle = new System.Windows.Forms.Button();
            this.labelYetki = new System.Windows.Forms.Label();
            this.dataGridViewKullanicilar = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonKullaniciSil = new System.Windows.Forms.Button();
            this.buttonKullaniciGuncelle = new System.Windows.Forms.Button();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonCalisan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciTc
            // 
            this.kullaniciTc.Location = new System.Drawing.Point(153, 54);
            this.kullaniciTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciTc.Name = "kullaniciTc";
            this.kullaniciTc.Size = new System.Drawing.Size(232, 22);
            this.kullaniciTc.TabIndex = 0;
            this.kullaniciTc.TextChanged += new System.EventHandler(this.kullaniciTc_TextChanged);
            this.kullaniciTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciTc_KeyPress);
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTc.Location = new System.Drawing.Point(82, 57);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(37, 19);
            this.labelTc.TabIndex = 1;
            this.labelTc.Text = "TC:";
            // 
            // labelKAd
            // 
            this.labelKAd.AutoSize = true;
            this.labelKAd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelKAd.Location = new System.Drawing.Point(82, 100);
            this.labelKAd.Name = "labelKAd";
            this.labelKAd.Size = new System.Drawing.Size(41, 19);
            this.labelKAd.TabIndex = 3;
            this.labelKAd.Text = "Adı:";
            // 
            // kullaniciAd
            // 
            this.kullaniciAd.Location = new System.Drawing.Point(153, 102);
            this.kullaniciAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAd.Name = "kullaniciAd";
            this.kullaniciAd.Size = new System.Drawing.Size(232, 22);
            this.kullaniciAd.TabIndex = 2;
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSoyad.Location = new System.Drawing.Point(82, 150);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(64, 19);
            this.labelSoyad.TabIndex = 7;
            this.labelSoyad.Text = "Soyadı:";
            // 
            // kullaniciSoyad
            // 
            this.kullaniciSoyad.Location = new System.Drawing.Point(153, 153);
            this.kullaniciSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciSoyad.Name = "kullaniciSoyad";
            this.kullaniciSoyad.Size = new System.Drawing.Size(232, 22);
            this.kullaniciSoyad.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmail.Location = new System.Drawing.Point(82, 197);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 19);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email:";
            // 
            // kullaniciEmail
            // 
            this.kullaniciEmail.Location = new System.Drawing.Point(153, 199);
            this.kullaniciEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciEmail.Name = "kullaniciEmail";
            this.kullaniciEmail.Size = new System.Drawing.Size(232, 22);
            this.kullaniciEmail.TabIndex = 8;
            this.kullaniciEmail.TextChanged += new System.EventHandler(this.kullaniciEmail_TextChanged);
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelParola.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelParola.Location = new System.Drawing.Point(82, 245);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(65, 19);
            this.labelParola.TabIndex = 11;
            this.labelParola.Text = "Parola:";
            // 
            // kullaniciParola
            // 
            this.kullaniciParola.Location = new System.Drawing.Point(153, 247);
            this.kullaniciParola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciParola.Name = "kullaniciParola";
            this.kullaniciParola.Size = new System.Drawing.Size(232, 22);
            this.kullaniciParola.TabIndex = 10;
            // 
            // buttonKullaniciEkle
            // 
            this.buttonKullaniciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.buttonKullaniciEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKullaniciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKullaniciEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullaniciEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKullaniciEkle.Location = new System.Drawing.Point(107, 382);
            this.buttonKullaniciEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKullaniciEkle.Name = "buttonKullaniciEkle";
            this.buttonKullaniciEkle.Size = new System.Drawing.Size(280, 28);
            this.buttonKullaniciEkle.TabIndex = 12;
            this.buttonKullaniciEkle.Text = "Kullanıcı Ekle";
            this.buttonKullaniciEkle.UseVisualStyleBackColor = false;
            this.buttonKullaniciEkle.Click += new System.EventHandler(this.buttonKullaniciEkle_Click);
            // 
            // labelYetki
            // 
            this.labelYetki.AutoSize = true;
            this.labelYetki.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYetki.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelYetki.Location = new System.Drawing.Point(82, 294);
            this.labelYetki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYetki.Name = "labelYetki";
            this.labelYetki.Size = new System.Drawing.Size(53, 19);
            this.labelYetki.TabIndex = 14;
            this.labelYetki.Text = "Yetki:";
            // 
            // dataGridViewKullanicilar
            // 
            this.dataGridViewKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKullanicilar.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewKullanicilar.Location = new System.Drawing.Point(432, 54);
            this.dataGridViewKullanicilar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            this.dataGridViewKullanicilar.Size = new System.Drawing.Size(797, 374);
            this.dataGridViewKullanicilar.TabIndex = 15;
            this.dataGridViewKullanicilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKullanicilar_CellContentClick);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 400;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // buttonKullaniciSil
            // 
            this.buttonKullaniciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.buttonKullaniciSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKullaniciSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKullaniciSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullaniciSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKullaniciSil.Location = new System.Drawing.Point(107, 436);
            this.buttonKullaniciSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKullaniciSil.Name = "buttonKullaniciSil";
            this.buttonKullaniciSil.Size = new System.Drawing.Size(280, 28);
            this.buttonKullaniciSil.TabIndex = 17;
            this.buttonKullaniciSil.Text = "Kullanıcı Sil";
            this.buttonKullaniciSil.UseVisualStyleBackColor = false;
            this.buttonKullaniciSil.Click += new System.EventHandler(this.buttonKullaniciSil_Click);
            // 
            // buttonKullaniciGuncelle
            // 
            this.buttonKullaniciGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.buttonKullaniciGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKullaniciGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKullaniciGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKullaniciGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKullaniciGuncelle.Location = new System.Drawing.Point(107, 491);
            this.buttonKullaniciGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKullaniciGuncelle.Name = "buttonKullaniciGuncelle";
            this.buttonKullaniciGuncelle.Size = new System.Drawing.Size(280, 28);
            this.buttonKullaniciGuncelle.TabIndex = 18;
            this.buttonKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            this.buttonKullaniciGuncelle.UseVisualStyleBackColor = false;
            this.buttonKullaniciGuncelle.Click += new System.EventHandler(this.buttonKullaniciGuncelle_Click);
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(185, 294);
            this.radioButtonAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(79, 23);
            this.radioButtonAdmin.TabIndex = 20;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // radioButtonCalisan
            // 
            this.radioButtonCalisan.AutoSize = true;
            this.radioButtonCalisan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCalisan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonCalisan.Location = new System.Drawing.Point(280, 294);
            this.radioButtonCalisan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonCalisan.Name = "radioButtonCalisan";
            this.radioButtonCalisan.Size = new System.Drawing.Size(86, 23);
            this.radioButtonCalisan.TabIndex = 21;
            this.radioButtonCalisan.TabStop = true;
            this.radioButtonCalisan.Text = "Çalışan";
            this.radioButtonCalisan.UseVisualStyleBackColor = true;
            this.radioButtonCalisan.CheckedChanged += new System.EventHandler(this.radioButtonCalisan_CheckedChanged);
            // 
            // adminKullaniciFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1245, 556);
            this.Controls.Add(this.radioButtonCalisan);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.buttonKullaniciGuncelle);
            this.Controls.Add(this.buttonKullaniciSil);
            this.Controls.Add(this.dataGridViewKullanicilar);
            this.Controls.Add(this.labelYetki);
            this.Controls.Add(this.buttonKullaniciEkle);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.kullaniciParola);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.kullaniciEmail);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.kullaniciSoyad);
            this.Controls.Add(this.labelKAd);
            this.Controls.Add(this.kullaniciAd);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.kullaniciTc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminKullaniciFormu";
            this.Text = "adminKullanicilar";
            this.Load += new System.EventHandler(this.adminKullaniciFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciTc;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelKAd;
        private System.Windows.Forms.TextBox kullaniciAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.TextBox kullaniciSoyad;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox kullaniciEmail;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox kullaniciParola;
        private System.Windows.Forms.Button buttonKullaniciEkle;
        private System.Windows.Forms.Label labelYetki;
        private System.Windows.Forms.DataGridView dataGridViewKullanicilar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonKullaniciSil;
        private System.Windows.Forms.Button buttonKullaniciGuncelle;
        private System.Windows.Forms.RadioButton radioButtonCalisan;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
    }
}