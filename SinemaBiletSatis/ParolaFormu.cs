using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; 
using System.Data.SqlClient;

namespace SinemaBiletSatis
{
    public partial class ParolaFormu : Form
    {
        public ParolaFormu()
        {
            InitializeComponent();
        }

        public bool Gonder(string konu, string parola)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("mail@gmail.com");//buraya kendi gmail hesabınız//
            ePosta.To.Add(emailText.Text);//parolayı unutanın maili textboxdan çektik.
            ePosta.Subject = konu; //butonda veri tabanı çekdikden sonra aldımız değer konu değeri//
            ePosta.Body = "Parolanız:" + parola;  
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("mail@gmail.com", "parolabız"); //kendi gmail hesabiniz ve parolası
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
        private void gonder_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed) //eğer bağlantı kapalıysa
            {
                connection.Open(); //bağlantıyı aç
            }

            SqlCommand com = new SqlCommand("Select * from kullanicilar where kTc='" + tcNo.Text.Trim() +
            "'and kEmail='" + emailText.Text.ToString() + "'", connection);
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
                //Burada verdiği tc ve mail doğruysa parolayı veritabanından çekip gönder fonksiyonuna göndereceğiz.
                string parola = oku["kParola"].ToString(); 
                MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollandı");
                Gonder("Unutmuş Olduğunuz Parolanız", parola);
                connection.Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmadı");
            }
            connection.Close();
        }

        private void tcNo_TextChanged(object sender, EventArgs e)
        {
            tcNo.MaxLength = 11;
            if (tcNo.Text.Length < 11 || tcNo.Text.Length > 11)
            {
                errorProvider.SetError(this.tcNo, "11 Karakter girin");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}


