namespace SinemaBiletSatis
{
    partial class ParolaFormu
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
            this.tcNo = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.gonder = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tcNo
            // 
            this.tcNo.Location = new System.Drawing.Point(99, 91);
            this.tcNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcNo.Name = "tcNo";
            this.tcNo.Size = new System.Drawing.Size(257, 22);
            this.tcNo.TabIndex = 0;
            this.tcNo.TextChanged += new System.EventHandler(this.tcNo_TextChanged);
            this.tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcNo_KeyPress);
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(163)))), ((int)(((byte)(118)))));
            this.tc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tc.ForeColor = System.Drawing.Color.Black;
            this.tc.Location = new System.Drawing.Point(32, 91);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(46, 17);
            this.tc.TabIndex = 1;
            this.tc.Text = "Tc No";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.errorProvider.SetIconAlignment(this.emailLabel, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.emailLabel.Location = new System.Drawing.Point(32, 154);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(99, 154);
            this.emailText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(257, 22);
            this.emailText.TabIndex = 3;
            // 
            // gonder
            // 
            this.gonder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gonder.Location = new System.Drawing.Point(99, 219);
            this.gonder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(256, 46);
            this.gonder.TabIndex = 4;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ParolaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(163)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(415, 375);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.tcNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ParolaFormu";
            this.Text = "Parola Formu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcNo;
        private System.Windows.Forms.Label tc;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}