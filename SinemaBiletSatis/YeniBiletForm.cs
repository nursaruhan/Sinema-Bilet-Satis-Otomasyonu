using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaBiletSatis.Controller;
using SinemaBiletSatis.Modeller;
namespace SinemaBiletSatis
{
    public partial class YeniBiletForm : Form
    {
        int[] secilenkoltukIdler = new int[36];
        String ad, salon, saat, filmadi, filmgun, kAd, kSoyad;
        public String[] satilankoltuklar { get; set; }
        Bilet bilet = new Bilet();
        biletcontroller biletcontroller = new biletcontroller();
        idController idController = new idController();

        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
        private void yazdir_Click(object sender, EventArgs e)
        {

        }



        int koltuksayisi = 0;

        public YeniBiletForm(String film, String salonno, String seanssaati, String[] koltuklar, DateTime seciligun, String kullanciAd, String kullanciSoyad)
        {
            InitializeComponent();
            ad = kullanciAd + " " + kullanciSoyad;
            filmadi = film;
            salon = salonno;
            saat = seanssaati;
            filmgun = seciligun.ToString("yyyy-MM-dd");
            satilankoltuklar = koltuklar;
            kAd = kullanciAd;
            kSoyad = kullanciSoyad;
        }

        private void Biletal_Load(object sender, EventArgs e)
        {
            biletsat.Visible = true;
            rezerveet.Visible = true;
            yazdir.Visible = false;
            ucretturu.Enabled = true;
            odeme.Enabled = true;
            Sad.Enabled = true;
            Ssoyad.Enabled = true;

            label1.Text = filmadi;
            label2.Text = ad;
            label3.Text = salon;
            label4.Text = saat;
            label6.Text = filmgun;
            for (int i = 0; i < 36; i++)
            {
                if (satilankoltuklar[i] != null)
                {                                         //secilileri yazdırma secililier bir diziye atanıp biletala yollancak ve secili alanlar kırmızı yapılcak
                    koltukno.Text += satilankoltuklar[i] + " ";
                    secilenkoltukIdler[i] = idController.koltukIdGetir(satilankoltuklar[i]);
                    koltuksayisi += 1;
                }
                else
                {
                    secilenkoltukIdler[i] = 0;
                }
            }
            bilet.fId = idController.fIdGetir(filmadi);
            bilet.kId = idController.kIdGetir(kAd, kSoyad);
            bilet.salonId = idController.salonIdGetir(salon);
            bilet.seansId = idController.seansIdGetir(saat);
            UcretCombo(ucretturu);
            odemeCombo(odeme);
        }

        public void UcretCombo(ComboBox ucretturu)
        {
            try
            {
                ucretturu.Items.Clear();
                SqlCommand ucretler = new SqlCommand("SELECT * FROM ucret", connection);
                ucretler.CommandType = CommandType.Text;
                SqlDataReader ucretadlari;
                connection.Open();
                ucretadlari = ucretler.ExecuteReader();
                while (ucretadlari.Read())
                {
                    ucretturu.Items.Add(ucretadlari["ucretAd"]);
                }
                ucretadlari.Close();
                connection.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("ucretcomco" + hata.Message);
            }
        }


        public void odemeCombo(ComboBox odeme)
        {
            try
            {
                odeme.Items.Clear();
                odeme.Items.Add("nakit");
                odeme.Items.Add("kredi kartı");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Combobox veri çekemedi" + hata.Message);
            }
        }
        public void anasayfayadon()
        {
            CalisanAnasayfaForm kullaniciForm = new CalisanAnasayfaForm(kAd, kSoyad); //kullanici adsoyad gonderme
            kullaniciForm.Show();
            this.Hide();

        }

        private void biletsat_Click(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Today;

            bilet.ucretId = idController.ucretIdGetir(ucretturu.Text);
            bilet.kisiUcreti = idController.fiyatGetir(ucretturu.Text);
            bilet.biletDurumu = "satıldı";
            bilet.seyirciAd = Sad.Text;
            bilet.seyirciSoyad = Ssoyad.Text;
            bilet.odemeTuru = odeme.Text;
            bilet.biletSatisTarihi = tarih;
            bilet.filmGun = DateTime.Parse(filmgun);
            if ((Sad.Text != "") && (Ssoyad.Text != "") && (odeme.Text != "") && (ucretturu.Text != ""))
            {
                if (ucretturu.Text != "rezerve")
                {
                    for (int i = 0; i < 36; i++)
                    {
                        if (secilenkoltukIdler[i] != 0)
                        {                                         //secilileri yazdırma secililier bir diziye atanıp biletala yollancak ve secili alanlar kırmızı yapılcak
                            bilet.koltukId = secilenkoltukIdler[i];
                            biletcontroller.biletEkle(bilet);
                            visibleDegistir();
                            yazdir.Visible = true;
                            ucretturu.Enabled = false;
                            odeme.Enabled = false;
                            Sad.Enabled = false;
                            Ssoyad.Enabled = false;
                        }
                    }
                    ucretlabel.Text = (koltuksayisi * bilet.kisiUcreti).ToString();
                }
                else
                {
                    MessageBox.Show("bilet satma işleminde rezerve seçilemez.Lütfen ücret türünü değistiriniz.");
                }
            }
            else
            {
                MessageBox.Show("lütfen boş yerleri doldurunuz!");
            }
        }
        private void anasaydon_Click(object sender, EventArgs e)
        {
            anasayfayadon();
        }
        private void rezerveet_Click(object sender, EventArgs e)
        {
            bilet.ucretId = idController.ucretIdGetir(ucretturu.Text);
            bilet.kisiUcreti = idController.fiyatGetir(ucretturu.Text);
            bilet.biletDurumu = "rezerve";
            bilet.seyirciAd = Sad.Text;
            bilet.seyirciSoyad = Ssoyad.Text;
            bilet.odemeTuru = "satın alınırken alınacak";
            bilet.biletSatisTarihi = DateTime.Today;
            bilet.filmGun = DateTime.Parse(filmgun);
            if ((Sad.Text != "") && (Ssoyad.Text != ""))
            {
                if (ucretturu.Text == "rezerve")
                {
                   
                    for (int i = 0; i < 36; i++)
                    {
                        if (secilenkoltukIdler[i] != 0)
                        {                                         //secilileri yazdırma secililier bir diziye atanıp biletala yollancak ve secili alanlar kırmızı yapılcak
                            bilet.koltukId = secilenkoltukIdler[i];
                            biletcontroller.biletEkle(bilet);
                            yazdir.Visible = true;
                            visibleDegistir();
                            ucretturu.Enabled = false;
                            odeme.Enabled = false;
                            Sad.Enabled = false;
                            Ssoyad.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("rezerve etme işleminde lütfen rezerve yi seçiniz.");
                }
            }
            else
            {
                MessageBox.Show("lütfen boş yerleri doldurunuz!");
            }

        }

        public void visibleDegistir()
        {
            if (biletsat.Visible == true || rezerveet.Visible == true)
            {
                biletsat.Visible = false;
                rezerveet.Visible = false;
            }
        }
    }
}
