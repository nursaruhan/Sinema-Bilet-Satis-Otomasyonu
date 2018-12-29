namespace SinemaBiletSatis
{
    partial class LoginFormu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormu));
            this.parola = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.parolaGoster = new System.Windows.Forms.CheckBox();
            this.parolamiUnuttum = new System.Windows.Forms.Button();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelEmail = new System.Windows.Forms.Label();
            this.girisYap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parola
            // 
            this.parola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.parola.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parola.Location = new System.Drawing.Point(627, 232);
            this.parola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(252, 30);
            this.parola.TabIndex = 2;
            this.parola.TextChanged += new System.EventHandler(this.parola_TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.Location = new System.Drawing.Point(627, 157);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(252, 30);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.labelParola.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelParola.ForeColor = System.Drawing.Color.Black;
            this.labelParola.Location = new System.Drawing.Point(529, 235);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(68, 22);
            this.labelParola.TabIndex = 5;
            this.labelParola.Text = "Parola:";
            // 
            // parolaGoster
            // 
            this.parolaGoster.AutoSize = true;
            this.parolaGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.parolaGoster.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolaGoster.ForeColor = System.Drawing.Color.Black;
            this.parolaGoster.Location = new System.Drawing.Point(913, 237);
            this.parolaGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parolaGoster.Name = "parolaGoster";
            this.parolaGoster.Size = new System.Drawing.Size(142, 26);
            this.parolaGoster.TabIndex = 6;
            this.parolaGoster.Text = "Parola Göster";
            this.parolaGoster.UseVisualStyleBackColor = false;
            this.parolaGoster.CheckedChanged += new System.EventHandler(this.parolaGoster_CheckedChanged);
            // 
            // parolamiUnuttum
            // 
            this.parolamiUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.parolamiUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parolamiUnuttum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.parolamiUnuttum.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.parolamiUnuttum.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.parolamiUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parolamiUnuttum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parolamiUnuttum.Location = new System.Drawing.Point(533, 404);
            this.parolamiUnuttum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parolamiUnuttum.Name = "parolamiUnuttum";
            this.parolamiUnuttum.Size = new System.Drawing.Size(415, 39);
            this.parolamiUnuttum.TabIndex = 7;
            this.parolamiUnuttum.Text = "Parolamı Unuttum";
            this.parolamiUnuttum.UseVisualStyleBackColor = false;
            this.parolamiUnuttum.Click += new System.EventHandler(this.parolamiUnuttum_Click);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.BlinkRate = 400;
            this.errorProviderLogin.ContainerControl = this;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(529, 160);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(70, 22);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-mail:";
            // 
            // girisYap
            // 
            this.girisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisYap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.girisYap.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.girisYap.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.girisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.girisYap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girisYap.Location = new System.Drawing.Point(533, 326);
            this.girisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(415, 41);
            this.girisYap.TabIndex = 9;
            this.girisYap.Text = "Giriş";
            this.girisYap.UseVisualStyleBackColor = false;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::SinemaBiletSatis.Properties.Resources.asd;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(163)))), ((int)(((byte)(118)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1058, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.parolamiUnuttum);
            this.Controls.Add(this.parolaGoster);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.email);
            this.Controls.Add(this.parola);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginFormu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.CheckBox parolaGoster;
        private System.Windows.Forms.Button parolamiUnuttum;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button girisYap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

