namespace SinemaBiletSatis
{
    partial class adminBiletFormu
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
            this.dataGridViewBiletSatis = new System.Windows.Forms.DataGridView();
            this.toplamTutar = new System.Windows.Forms.Label();
            this.labelBiletDurumu = new System.Windows.Forms.Label();
            this.radioButtonSatilan = new System.Windows.Forms.RadioButton();
            this.radioButtonRezerve = new System.Windows.Forms.RadioButton();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonKasayiBosalt = new System.Windows.Forms.Button();
            this.buttonGunlukToplam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiletSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBiletSatis
            // 
            this.dataGridViewBiletSatis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.dataGridViewBiletSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBiletSatis.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBiletSatis.Location = new System.Drawing.Point(125, 241);
            this.dataGridViewBiletSatis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBiletSatis.Name = "dataGridViewBiletSatis";
            this.dataGridViewBiletSatis.RowTemplate.Height = 24;
            this.dataGridViewBiletSatis.Size = new System.Drawing.Size(1013, 210);
            this.dataGridViewBiletSatis.TabIndex = 0;
            // 
            // toplamTutar
            // 
            this.toplamTutar.AutoSize = true;
            this.toplamTutar.Location = new System.Drawing.Point(865, 98);
            this.toplamTutar.Name = "toplamTutar";
            this.toplamTutar.Size = new System.Drawing.Size(0, 17);
            this.toplamTutar.TabIndex = 1;
            // 
            // labelBiletDurumu
            // 
            this.labelBiletDurumu.AutoSize = true;
            this.labelBiletDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.labelBiletDurumu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBiletDurumu.Location = new System.Drawing.Point(339, 73);
            this.labelBiletDurumu.Name = "labelBiletDurumu";
            this.labelBiletDurumu.Size = new System.Drawing.Size(118, 19);
            this.labelBiletDurumu.TabIndex = 2;
            this.labelBiletDurumu.Text = "Bilet Durumu:";
            // 
            // radioButtonSatilan
            // 
            this.radioButtonSatilan.AutoSize = true;
            this.radioButtonSatilan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSatilan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSatilan.Location = new System.Drawing.Point(476, 73);
            this.radioButtonSatilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonSatilan.Name = "radioButtonSatilan";
            this.radioButtonSatilan.Size = new System.Drawing.Size(82, 23);
            this.radioButtonSatilan.TabIndex = 3;
            this.radioButtonSatilan.TabStop = true;
            this.radioButtonSatilan.Text = "Satılan";
            this.radioButtonSatilan.UseVisualStyleBackColor = true;
            // 
            // radioButtonRezerve
            // 
            this.radioButtonRezerve.AutoSize = true;
            this.radioButtonRezerve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRezerve.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonRezerve.Location = new System.Drawing.Point(584, 73);
            this.radioButtonRezerve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonRezerve.Name = "radioButtonRezerve";
            this.radioButtonRezerve.Size = new System.Drawing.Size(141, 23);
            this.radioButtonRezerve.TabIndex = 4;
            this.radioButtonRezerve.TabStop = true;
            this.radioButtonRezerve.Text = "Rezerve Edilen";
            this.radioButtonRezerve.UseVisualStyleBackColor = true;
            // 
            // buttonListele
            // 
            this.buttonListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.buttonListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonListele.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListele.Location = new System.Drawing.Point(417, 123);
            this.buttonListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(296, 31);
            this.buttonListele.TabIndex = 5;
            this.buttonListele.Text = "Toplam Liste";
            this.buttonListele.UseVisualStyleBackColor = false;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonKasayiBosalt
            // 
            this.buttonKasayiBosalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.buttonKasayiBosalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKasayiBosalt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKasayiBosalt.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKasayiBosalt.Location = new System.Drawing.Point(417, 482);
            this.buttonKasayiBosalt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonKasayiBosalt.Name = "buttonKasayiBosalt";
            this.buttonKasayiBosalt.Size = new System.Drawing.Size(296, 32);
            this.buttonKasayiBosalt.TabIndex = 6;
            this.buttonKasayiBosalt.Text = "Kasayı Boşalt";
            this.buttonKasayiBosalt.UseVisualStyleBackColor = false;
            this.buttonKasayiBosalt.Click += new System.EventHandler(this.buttonKasayiBosalt_Click);
            // 
            // buttonGunlukToplam
            // 
            this.buttonGunlukToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.buttonGunlukToplam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGunlukToplam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGunlukToplam.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGunlukToplam.Location = new System.Drawing.Point(417, 190);
            this.buttonGunlukToplam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGunlukToplam.Name = "buttonGunlukToplam";
            this.buttonGunlukToplam.Size = new System.Drawing.Size(296, 30);
            this.buttonGunlukToplam.TabIndex = 7;
            this.buttonGunlukToplam.Text = "Günlük Toplam Satılan Bilet";
            this.buttonGunlukToplam.UseVisualStyleBackColor = false;
            this.buttonGunlukToplam.Click += new System.EventHandler(this.buttonGunlukToplam_Click);
            // 
            // adminBiletFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.buttonGunlukToplam);
            this.Controls.Add(this.buttonKasayiBosalt);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.radioButtonRezerve);
            this.Controls.Add(this.radioButtonSatilan);
            this.Controls.Add(this.labelBiletDurumu);
            this.Controls.Add(this.toplamTutar);
            this.Controls.Add(this.dataGridViewBiletSatis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminBiletFormu";
            this.Text = "adminBilet";
            this.Load += new System.EventHandler(this.adminBiletFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiletSatis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBiletSatis;
        private System.Windows.Forms.Label toplamTutar;
        private System.Windows.Forms.Label labelBiletDurumu;
        private System.Windows.Forms.RadioButton radioButtonSatilan;
        private System.Windows.Forms.RadioButton radioButtonRezerve;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonKasayiBosalt;
        private System.Windows.Forms.Button buttonGunlukToplam;
    }
}