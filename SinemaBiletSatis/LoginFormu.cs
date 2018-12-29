using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SinemaBiletSatis.Controller;
using SinemaBiletSatis.Modeller;

namespace SinemaBiletSatis
{
    public partial class LoginFormu : Form
    {
        public LoginFormu()
        {
            InitializeComponent();
        }
    

        private void girisYap_Click(object sender, EventArgs e)
        {
            adminKullaniciController kullaniciController = new adminKullaniciController();
            loginController loginController = new loginController();
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Email = email.Text;
            kullanici.Parola = parola.Text;
            int yetki;
            if (kullanici.Email == "" || kullanici.Parola == "")
            {
                MessageBox.Show("Boşlukları Doldurun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (kullaniciController.EmailFormatKontrol(kullanici.Email) == true)
                {
                   yetki = loginController.girisYapKontrol(kullanici.Email, kullanici.Parola);
                    if (yetki == 0)
                    {
                        adminAnasayfaFormu adminAnasayfa = new adminAnasayfaFormu(kullanici.Email);
                        adminAnasayfa.Show();
                        this.Hide();
                    }
                    else if(yetki == 1)
                    {   
                        CalisanAnasayfaForm calisanAnasayfa = new CalisanAnasayfaForm(kullanici.Email, "");
                        calisanAnasayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            parola.PasswordChar = '*';      
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                     @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email.Text, pattern))
            {
                errorProviderLogin.Clear();
            }
            else
            {
                errorProviderLogin.SetError(this.email, "Doğru formatta girin");
            }
        }
        private void parola_TextChanged(object sender, EventArgs e)
        {
        }

        private void parolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (parolaGoster.Checked){ 
                //karakteri göster.
                parola.PasswordChar = '\0';
            }
            else{
                parola.PasswordChar = '*';
            }
        }

        private void parolamiUnuttum_Click(object sender, EventArgs e){
           ParolaFormu unuttum = new ParolaFormu();
           unuttum.Show();           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
    }
}

