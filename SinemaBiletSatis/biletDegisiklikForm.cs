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
    public partial class biletDegisiklikForm : Form
    {
        String kad, ksoyad;
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
        String secili;
        String biletDurumu;
        Bilet bilet = new Bilet();
        biletcontroller biletcontroller = new biletcontroller();
        idController idController = new idController();
        public biletDegisiklikForm(String ad, String soyAd)
        {
            InitializeComponent();
            kad = ad;
            ksoyad = soyAd;
        }

        private void rezerveSat_Load(object sender, EventArgs e)
        {
            kadSoyad.Text = kad + ksoyad;
        }

        private void biletListele_Click(object sender, EventArgs e)
        {
            if (mAd.Text != null && mSoyad.Text != null)
            {
                biletAra(mAd.Text, mSoyad.Text);
            }
            else
            {
                MessageBox.Show("lütfen seyirci ad ve soyad giriniz");
            }
        }
        private void biletSil_Click(object sender, EventArgs e)
        {
            String secili;
            String biletDurumu;
            Bilet silbilet = new Bilet();
            secili = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            biletDurumu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            silbilet.biletId = int.Parse(secili);

            if (biletDurumu == "satıldı")
            {
                biletcontroller.biletSilFonk(silbilet.biletId);
            }
            else
            {
                MessageBox.Show("bu bilgilerle satılmış bilet bilgisi yok!");
            }
            biletAra(mAd.Text, mSoyad.Text);
        }
        private void rezerveSil_Click(object sender, EventArgs e)
        {
            Bilet silincekbilet = new Bilet();
            secili = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            biletDurumu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            silincekbilet.biletId = int.Parse(secili);

            if (biletDurumu == "rezerve")
            {
                biletcontroller.rezervesilFonk(silincekbilet.biletId);
            }
            else
            {
                MessageBox.Show("bu bilgilerle rezerve edilmiş bilet bilgisi yok!");
            }
            biletAra(mAd.Text, mSoyad.Text);
        }
        private void rezerveSat_Click(object sender, EventArgs e)
        {
            biletDurumu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (biletDurumu == "rezerve")
            {
                odemeComb.Visible = true;
                ucretComb.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                UcretComboadd(ucretComb);
                odemeComboadd(odemeComb);

                secili = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                biletDurumu = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("bu bilet satılmıştır.rezerve durumunda degildir.");
            }
        }

        public void UcretComboadd(ComboBox ucretturu)
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
        public void odemeComboadd(ComboBox odeme)
        {
            odeme.Items.Clear();
            odeme.Items.Add("nakit");
            odeme.Items.Add("kredi kartı");
        }
        private void biletAra(String mAd, String mSoyad)
        {
            connection.Open();
            dataGridView1.Visible = true; //sorguda guncel saati gecmis olanlar gosterilmiyo convert ile
            SqlDataAdapter da = new SqlDataAdapter(" SELECT dbo.bilet.biletId as 'bilet numarası', dbo.bilet.biletDurumu, dbo.bilet.seyirciAd as'seyirci ad', dbo.bilet.seyirciSoyad as 'seyirci soyad', dbo.filmler.fAd as 'film adı', dbo.koltuk.koltukHarfNumara, dbo.kullanicilar.kAd as 'gişeci adı', dbo.kullanicilar.kSoyad as 'gişeci soyadı', dbo.seans.seansSaat, dbo.salon.salonAd FROM    dbo.bilet INNER JOIN  dbo.filmler ON dbo.bilet.fId = dbo.filmler.fId  INNER JOIN  dbo.koltuk ON dbo.bilet.koltukId = dbo.koltuk.koltukId INNER JOIN   dbo.kullanicilar ON dbo.bilet.kId = dbo.kullanicilar.kId INNER JOIN  dbo.salon ON dbo.bilet.salonId = dbo.salon.salonId INNER JOIN dbo.seans ON dbo.bilet.seansId = dbo.seans.seansId INNER JOIN dbo.ucret ON dbo.bilet.ucretId = dbo.ucret.ucretId and seyirciAd ='" + mAd + "' and seyirciSoyad='" + mSoyad + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
            if (dataGridView1.Rows.Count > 0)
            {
                biletListele.Visible = true;
                biletSil.Visible = true;
                rezerveSil.Visible = true;
                rezerveSat.Visible = true;
            }
            else
            {
                MessageBox.Show("aranan isim bilgilerine gore satılmış veya rezerve edilmiş bilet bilgisi bulunamadı");
            }
        }

        private void rezervesonsat_Click(object sender, EventArgs e)
        {
            if (ucretComb.Text != "" && odemeComb.Text != "")
            {
                bilet.ucretId = idController.ucretIdGetir(ucretComb.Text);
                bilet.kisiUcreti = idController.fiyatGetir(ucretComb.Text);
                bilet.kId = idController.kIdGetir(kad, ksoyad);
                bilet.odemeTuru = odemeComb.Text;
                bilet.biletId = int.Parse(secili);
                biletcontroller.rezerveSatFonk(bilet);
                biletAra(mAd.Text, mSoyad.Text);

            }
            else
            {
                MessageBox.Show("lütfen boş yerleri doldurunuz.");
            }
        }
        private void don_Click(object sender, EventArgs e)
        {
            CalisanAnasayfaForm form2yegit = new CalisanAnasayfaForm(kad, ksoyad);
            form2yegit.Show();
            this.Hide();
        }
    }
}
