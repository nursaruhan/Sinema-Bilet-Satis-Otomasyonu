using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaBiletSatis.Controller;
using SinemaBiletSatis.Modeller;

namespace SinemaBiletSatis
{
    public partial class adminKullaniciFormu : Form
    {
        int yetki = -1;
        public adminKullaniciFormu()
        {
            InitializeComponent();
            adminKullaniciController kullaniciController = new adminKullaniciController();
            dataGridViewKullanicilar.DataSource = kullaniciController.KullanicilariGoster();
        }
        public void verileriTemizle()
        {
            kullaniciTc.Clear();
            kullaniciAd.Clear();
            kullaniciSoyad.Clear();
            kullaniciEmail.Clear();
            kullaniciParola.Clear();
            yetki = -1;
            radioButtonCalisan.Checked = false;
            radioButtonAdmin.Checked = false;
        }
        private void buttonKullaniciEkle_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar();
            adminKullaniciController kullaniciController = new adminKullaniciController();
            kullanici.Tc = kullaniciTc.Text;
            kullanici.Adi = kullaniciAd.Text;
            kullanici.Soyadi = kullaniciSoyad.Text;
            kullanici.Email = kullaniciEmail.Text;
            kullanici.Parola = kullaniciParola.Text;
            kullanici.Yetki = yetki;

            if (kullanici.Tc == "" || kullanici.Adi == "" || kullanici.Soyadi == ""||
                kullanici.Email == "" || kullanici.Parola == ""|| kullanici.Yetki == -1){
                MessageBox.Show("Boş Bırakmayın!");
            }
            else
            {
                if (kullaniciController.EmailFormatKontrol(kullanici.Email) ==true)
                {
                    if (kullanici.Tc.Length == 11)
                    {
                        kullaniciController.KullaniciEkle(kullanici);
                        dataGridViewKullanicilar.DataSource = kullaniciController.KullanicilariGoster();
                        verileriTemizle();
                    }
                    else{
                        MessageBox.Show("11 karakter olmalı");
                    }
                }    
            }        
        }
        private void kullaniciTc_TextChanged(object sender, EventArgs e)
        {
            kullaniciTc.MaxLength = 11;
            if (kullaniciTc.Text.Length < 11 || kullaniciTc.Text.Length > 11){
                errorProvider.SetError(this.kullaniciTc, "11 Karakter girin");
            }
            else{
                errorProvider.Clear();
            }

        }

        private void kullaniciEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(kullaniciEmail.Text, pattern)){
                errorProvider.Clear();
            }
            else{
                errorProvider.SetError(this.kullaniciEmail, "Doğru formatta girin");
            }
        }
        string secilenKullaniciId = "-1";
        private void dataGridViewKullanicilar_CellContentClick(object sender, DataGridViewCellEventArgs e){
            secilenKullaniciId = dataGridViewKullanicilar.CurrentRow.Cells[0].Value.ToString();
            kullaniciTc.Text = dataGridViewKullanicilar.CurrentRow.Cells[1].Value.ToString();
            kullaniciAd.Text = dataGridViewKullanicilar.CurrentRow.Cells[2].Value.ToString();
            kullaniciSoyad.Text = dataGridViewKullanicilar.CurrentRow.Cells[3].Value.ToString();
            kullaniciEmail.Text = dataGridViewKullanicilar.CurrentRow.Cells[4].Value.ToString();
            kullaniciParola.Text = dataGridViewKullanicilar.CurrentRow.Cells[5].Value.ToString();
            if (dataGridViewKullanicilar.CurrentRow.Cells[6].Value.ToString() == "0")
            {
                radioButtonAdmin.Checked=true;
            }
            if (dataGridViewKullanicilar.CurrentRow.Cells[6].Value.ToString() == "1")
            {
                radioButtonCalisan.Checked = true;
            }
        }
        private void buttonKullaniciSil_Click(object sender, EventArgs e)
        {
            adminKullaniciController kullaniciController = new adminKullaniciController();
            kullaniciController.KullaniciSil(secilenKullaniciId);
            dataGridViewKullanicilar.DataSource = kullaniciController.KullanicilariGoster(); 
            verileriTemizle();
            secilenKullaniciId = "-1";
        }

        private void buttonKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            adminKullaniciController kullaniciController = new adminKullaniciController();
            Kullanicilar kullanici = new Kullanicilar();
            kullanici.Id = secilenKullaniciId;
            kullanici.Tc = kullaniciTc.Text;
            kullanici.Adi = kullaniciAd.Text;
            kullanici.Soyadi = kullaniciSoyad.Text;
            kullanici.Email = kullaniciEmail.Text;
            kullanici.Parola = kullaniciParola.Text;
            kullanici.Yetki = yetki;
            if (secilenKullaniciId == "-1")
            {
                MessageBox.Show("Bilgisini güncellemek istediğiniz kullanıcıyı tablodan seçin!");
            }
            else
            {
                if (kullanici.Tc == "" || kullanici.Adi == "" || kullanici.Soyadi == "" ||
                    kullanici.Email == "" || kullanici.Parola == "" || kullanici.Yetki == -1)
                {
                    MessageBox.Show("Boş Bırakmayın!");
                }
                else
                {
                    if (kullaniciController.EmailFormatKontrol(kullanici.Email) == true)
                    {
                        if (kullanici.Tc.Length == 11)
                        {
                            kullaniciController.KullaniciGuncelle(kullanici);
                            dataGridViewKullanicilar.DataSource = kullaniciController.KullanicilariGoster();
                            verileriTemizle();
                            secilenKullaniciId = "-1";
                        }
                        else
                        {
                            MessageBox.Show("11 karakter olmalı");
                        }
                    }
                }
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdmin.Checked==true)
            {
                yetki = 0;
            }
        }

        private void radioButtonCalisan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCalisan.Checked==true)
            {
                yetki = 1;
            }
        }

        private void kullaniciTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void adminKullaniciFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
