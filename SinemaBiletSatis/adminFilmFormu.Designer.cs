namespace SinemaBiletSatis
{
    partial class adminFilmFormu
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
            this.fAd = new System.Windows.Forms.TextBox();
            this.fAfis = new System.Windows.Forms.TextBox();
            this.filmKaydet = new System.Windows.Forms.Button();
            this.dataGridViewFilm = new System.Windows.Forms.DataGridView();
            this.filmSalon = new System.Windows.Forms.ComboBox();
            this.salon = new System.Windows.Forms.Label();
            this.filmSeans = new System.Windows.Forms.ComboBox();
            this.Seans = new System.Windows.Forms.Label();
            this.fAdi = new System.Windows.Forms.Label();
            this.afis = new System.Windows.Forms.Label();
            this.ssEkle = new System.Windows.Forms.Button();
            this.filmler = new System.Windows.Forms.ComboBox();
            this.film = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salonSeansSil = new System.Windows.Forms.Button();
            this.dataGridViewSalonSeans = new System.Windows.Forms.DataGridView();
            this.filmSil = new System.Windows.Forms.Button();
            this.filmGuncelle = new System.Windows.Forms.Button();
            this.salonSeansGuncelle = new System.Windows.Forms.Button();
            this.afisSec = new System.Windows.Forms.Button();
            this.pictureBoxAfis = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dateTimeBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.baslangicTarihi = new System.Windows.Forms.Label();
            this.bitisTarihi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalonSeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // fAd
            // 
            this.fAd.Location = new System.Drawing.Point(152, 38);
            this.fAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fAd.Name = "fAd";
            this.fAd.Size = new System.Drawing.Size(263, 22);
            this.fAd.TabIndex = 2;
            // 
            // fAfis
            // 
            this.fAfis.Location = new System.Drawing.Point(155, 170);
            this.fAfis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fAfis.Name = "fAfis";
            this.fAfis.ReadOnly = true;
            this.fAfis.Size = new System.Drawing.Size(260, 22);
            this.fAfis.TabIndex = 3;
            // 
            // filmKaydet
            // 
            this.filmKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.filmKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmKaydet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmKaydet.ForeColor = System.Drawing.Color.Black;
            this.filmKaydet.Location = new System.Drawing.Point(155, 298);
            this.filmKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmKaydet.Name = "filmKaydet";
            this.filmKaydet.Size = new System.Drawing.Size(129, 32);
            this.filmKaydet.TabIndex = 4;
            this.filmKaydet.Text = "Film Kaydet";
            this.filmKaydet.UseVisualStyleBackColor = false;
            this.filmKaydet.Click += new System.EventHandler(this.filmKaydet_Click);
            // 
            // dataGridViewFilm
            // 
            this.dataGridViewFilm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.dataGridViewFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilm.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFilm.Location = new System.Drawing.Point(458, 34);
            this.dataGridViewFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFilm.Name = "dataGridViewFilm";
            this.dataGridViewFilm.RowTemplate.Height = 24;
            this.dataGridViewFilm.Size = new System.Drawing.Size(732, 289);
            this.dataGridViewFilm.TabIndex = 5;
            this.dataGridViewFilm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilm_CellContentClick);
            // 
            // filmSalon
            // 
            this.filmSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmSalon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmSalon.FormattingEnabled = true;
            this.filmSalon.Location = new System.Drawing.Point(155, 433);
            this.filmSalon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmSalon.Name = "filmSalon";
            this.filmSalon.Size = new System.Drawing.Size(260, 27);
            this.filmSalon.TabIndex = 6;
            this.filmSalon.SelectedIndexChanged += new System.EventHandler(this.filmSalon_SelectedIndexChanged);
            // 
            // salon
            // 
            this.salon.AutoSize = true;
            this.salon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.salon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salon.Location = new System.Drawing.Point(7, 441);
            this.salon.Name = "salon";
            this.salon.Size = new System.Drawing.Size(50, 19);
            this.salon.TabIndex = 7;
            this.salon.Text = "Salon";
            // 
            // filmSeans
            // 
            this.filmSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmSeans.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmSeans.FormattingEnabled = true;
            this.filmSeans.Location = new System.Drawing.Point(155, 485);
            this.filmSeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmSeans.Name = "filmSeans";
            this.filmSeans.Size = new System.Drawing.Size(260, 27);
            this.filmSeans.TabIndex = 8;
            // 
            // Seans
            // 
            this.Seans.AutoSize = true;
            this.Seans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.Seans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seans.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Seans.Location = new System.Drawing.Point(7, 492);
            this.Seans.Name = "Seans";
            this.Seans.Size = new System.Drawing.Size(50, 19);
            this.Seans.TabIndex = 9;
            this.Seans.Text = "Seans";
            // 
            // fAdi
            // 
            this.fAdi.AutoSize = true;
            this.fAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.fAdi.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.fAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fAdi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fAdi.Location = new System.Drawing.Point(7, 39);
            this.fAdi.Name = "fAdi";
            this.fAdi.Size = new System.Drawing.Size(75, 19);
            this.fAdi.TabIndex = 10;
            this.fAdi.Text = "Film Adı";
            // 
            // afis
            // 
            this.afis.AutoSize = true;
            this.afis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.afis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.afis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afis.Location = new System.Drawing.Point(7, 81);
            this.afis.Name = "afis";
            this.afis.Size = new System.Drawing.Size(84, 19);
            this.afis.TabIndex = 11;
            this.afis.Text = "Film Afişi";
            // 
            // ssEkle
            // 
            this.ssEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.ssEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ssEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ssEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ssEkle.Location = new System.Drawing.Point(155, 526);
            this.ssEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ssEkle.Name = "ssEkle";
            this.ssEkle.Size = new System.Drawing.Size(119, 32);
            this.ssEkle.TabIndex = 13;
            this.ssEkle.Text = "Kaydet";
            this.ssEkle.UseVisualStyleBackColor = false;
            this.ssEkle.Click += new System.EventHandler(this.ssEkle_Click);
            // 
            // filmler
            // 
            this.filmler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmler.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmler.FormattingEnabled = true;
            this.filmler.Location = new System.Drawing.Point(155, 389);
            this.filmler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmler.Name = "filmler";
            this.filmler.Size = new System.Drawing.Size(260, 27);
            this.filmler.TabIndex = 15;
            // 
            // film
            // 
            this.film.AutoSize = true;
            this.film.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.film.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.film.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.film.Location = new System.Drawing.Point(7, 390);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(68, 19);
            this.film.TabIndex = 16;
            this.film.Text = "Filmler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 18;
            // 
            // salonSeansSil
            // 
            this.salonSeansSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.salonSeansSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salonSeansSil.FlatAppearance.BorderSize = 0;
            this.salonSeansSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salonSeansSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salonSeansSil.Location = new System.Drawing.Point(294, 526);
            this.salonSeansSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salonSeansSil.Name = "salonSeansSil";
            this.salonSeansSil.Size = new System.Drawing.Size(121, 32);
            this.salonSeansSil.TabIndex = 19;
            this.salonSeansSil.Text = "Sil";
            this.salonSeansSil.UseVisualStyleBackColor = false;
            this.salonSeansSil.Click += new System.EventHandler(this.salonSeansSil_Click);
            // 
            // dataGridViewSalonSeans
            // 
            this.dataGridViewSalonSeans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.dataGridViewSalonSeans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalonSeans.Location = new System.Drawing.Point(458, 380);
            this.dataGridViewSalonSeans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSalonSeans.Name = "dataGridViewSalonSeans";
            this.dataGridViewSalonSeans.RowTemplate.Height = 24;
            this.dataGridViewSalonSeans.Size = new System.Drawing.Size(732, 208);
            this.dataGridViewSalonSeans.TabIndex = 14;
            this.dataGridViewSalonSeans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalonSeans_CellContentClick);
            // 
            // filmSil
            // 
            this.filmSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.filmSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmSil.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmSil.ForeColor = System.Drawing.Color.Black;
            this.filmSil.Location = new System.Drawing.Point(288, 298);
            this.filmSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmSil.Name = "filmSil";
            this.filmSil.Size = new System.Drawing.Size(127, 32);
            this.filmSil.TabIndex = 20;
            this.filmSil.Text = "Film Sil";
            this.filmSil.UseVisualStyleBackColor = false;
            this.filmSil.Click += new System.EventHandler(this.filmSil_Click);
            // 
            // filmGuncelle
            // 
            this.filmGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.filmGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filmGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmGuncelle.ForeColor = System.Drawing.Color.Black;
            this.filmGuncelle.Location = new System.Drawing.Point(155, 339);
            this.filmGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmGuncelle.Name = "filmGuncelle";
            this.filmGuncelle.Size = new System.Drawing.Size(260, 32);
            this.filmGuncelle.TabIndex = 21;
            this.filmGuncelle.Text = "Film Güncelle";
            this.filmGuncelle.UseVisualStyleBackColor = false;
            this.filmGuncelle.Click += new System.EventHandler(this.filmGuncelle_Click);
            // 
            // salonSeansGuncelle
            // 
            this.salonSeansGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.salonSeansGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salonSeansGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salonSeansGuncelle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salonSeansGuncelle.Location = new System.Drawing.Point(155, 562);
            this.salonSeansGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salonSeansGuncelle.Name = "salonSeansGuncelle";
            this.salonSeansGuncelle.Size = new System.Drawing.Size(260, 32);
            this.salonSeansGuncelle.TabIndex = 22;
            this.salonSeansGuncelle.Text = "Güncelle";
            this.salonSeansGuncelle.UseVisualStyleBackColor = false;
            this.salonSeansGuncelle.Click += new System.EventHandler(this.salonSeansGuncelle_Click);
            // 
            // afisSec
            // 
            this.afisSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.afisSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afisSec.FlatAppearance.BorderSize = 0;
            this.afisSec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.afisSec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.afisSec.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afisSec.Location = new System.Drawing.Point(319, 80);
            this.afisSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.afisSec.Name = "afisSec";
            this.afisSec.Size = new System.Drawing.Size(96, 27);
            this.afisSec.TabIndex = 23;
            this.afisSec.Text = "Gözat";
            this.afisSec.UseVisualStyleBackColor = false;
            this.afisSec.Click += new System.EventHandler(this.afisSec_Click);
            // 
            // pictureBoxAfis
            // 
            this.pictureBoxAfis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.pictureBoxAfis.Location = new System.Drawing.Point(155, 80);
            this.pictureBoxAfis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAfis.Name = "pictureBoxAfis";
            this.pictureBoxAfis.Size = new System.Drawing.Size(109, 86);
            this.pictureBoxAfis.TabIndex = 24;
            this.pictureBoxAfis.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dateTimeBaslangicTarihi
            // 
            this.dateTimeBaslangicTarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBaslangicTarihi.Location = new System.Drawing.Point(155, 211);
            this.dateTimeBaslangicTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeBaslangicTarihi.Name = "dateTimeBaslangicTarihi";
            this.dateTimeBaslangicTarihi.Size = new System.Drawing.Size(260, 27);
            this.dateTimeBaslangicTarihi.TabIndex = 25;
            // 
            // dateTimeBitisTarihi
            // 
            this.dateTimeBitisTarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBitisTarihi.Location = new System.Drawing.Point(155, 252);
            this.dateTimeBitisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeBitisTarihi.Name = "dateTimeBitisTarihi";
            this.dateTimeBitisTarihi.Size = new System.Drawing.Size(260, 27);
            this.dateTimeBitisTarihi.TabIndex = 26;
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.AutoSize = true;
            this.baslangicTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.baslangicTarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangicTarihi.Location = new System.Drawing.Point(7, 211);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(131, 19);
            this.baslangicTarihi.TabIndex = 27;
            this.baslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.AutoSize = true;
            this.bitisTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.bitisTarihi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bitisTarihi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisTarihi.Location = new System.Drawing.Point(8, 253);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(95, 19);
            this.bitisTarihi.TabIndex = 28;
            this.bitisTarihi.Text = "Bitiş Tarihi";
            // 
            // adminFilmFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1385, 655);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.baslangicTarihi);
            this.Controls.Add(this.dateTimeBitisTarihi);
            this.Controls.Add(this.dateTimeBaslangicTarihi);
            this.Controls.Add(this.pictureBoxAfis);
            this.Controls.Add(this.afisSec);
            this.Controls.Add(this.salonSeansGuncelle);
            this.Controls.Add(this.filmGuncelle);
            this.Controls.Add(this.filmSil);
            this.Controls.Add(this.salonSeansSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.film);
            this.Controls.Add(this.filmler);
            this.Controls.Add(this.ssEkle);
            this.Controls.Add(this.afis);
            this.Controls.Add(this.fAdi);
            this.Controls.Add(this.Seans);
            this.Controls.Add(this.filmSeans);
            this.Controls.Add(this.salon);
            this.Controls.Add(this.filmSalon);
            this.Controls.Add(this.dataGridViewFilm);
            this.Controls.Add(this.filmKaydet);
            this.Controls.Add(this.fAfis);
            this.Controls.Add(this.fAd);
            this.Controls.Add(this.dataGridViewSalonSeans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminFilmFormu";
            this.Text = "adminFilm";
            this.Load += new System.EventHandler(this.adminFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalonSeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox fAd;
        private System.Windows.Forms.TextBox fAfis;
        private System.Windows.Forms.Button filmKaydet;
        private System.Windows.Forms.DataGridView dataGridViewFilm;
        private System.Windows.Forms.ComboBox filmSalon;
        private System.Windows.Forms.Label salon;
        private System.Windows.Forms.ComboBox filmSeans;
        private System.Windows.Forms.Label Seans;
        private System.Windows.Forms.Label fAdi;
        private System.Windows.Forms.Label afis;
        private System.Windows.Forms.Button ssEkle;
        private System.Windows.Forms.ComboBox filmler;
        private System.Windows.Forms.Label film;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salonSeansSil;
        private System.Windows.Forms.DataGridView dataGridViewSalonSeans;
        private System.Windows.Forms.Button filmSil;
        private System.Windows.Forms.Button filmGuncelle;
        private System.Windows.Forms.Button salonSeansGuncelle;
        private System.Windows.Forms.Button afisSec;
        private System.Windows.Forms.PictureBox pictureBoxAfis;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dateTimeBitisTarihi;
        private System.Windows.Forms.Label baslangicTarihi;
        private System.Windows.Forms.Label bitisTarihi;
    }
}