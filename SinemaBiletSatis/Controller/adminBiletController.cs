using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatis.Controller
{
    class adminBiletController
    {
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

        public DataTable BiletleriGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT biletId, biletSatisTarihi, biletDurumu, kAd AS SatışYapanKişininAdı, kSoyad AS SatışYapanKişininSoyadı, fAd, ucretFiyat  FROM" +
                " bilet INNER JOIN kullanicilar ON bilet.kId = kullanicilar.kId INNER JOIN ucret ON bilet.ucretId = ucret.ucretId INNER JOIN filmler ON bilet.fId = filmler.fId   ", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable BiletDurumuBiletleriGoster(string biletDurumu)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT biletId, biletSatisTarihi, biletDurumu, kAd AS SatışYapanKişininAdı, kSoyad AS SatışYapanKişininSoyadı, fAd, ucretFiyat  FROM " +
                "bilet INNER JOIN kullanicilar ON bilet.kId = kullanicilar.kId INNER JOIN ucret ON bilet.ucretId = ucret.ucretId INNER JOIN filmler ON bilet.fId = filmler.fId  Where biletDurumu ='" + biletDurumu.ToString() + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable BugunSatilanBiletleriGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT biletId, biletSatisTarihi, biletDurumu, kAd AS SatışYapanKişininAdı, kSoyad AS SatışYapanKişininSoyadı, fAd, ucretFiyat  FROM " +
                "bilet INNER JOIN kullanicilar ON bilet.kId = kullanicilar.kId INNER JOIN ucret ON bilet.ucretId = ucret.ucretId INNER JOIN filmler ON bilet.fId = filmler.fId WHERE biletSatisTarihi = CONVERT(date, GETDATE()) AND biletDurumu = 'Satıldı'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //Bugun hariç kasayı bosaltır.
        public void gecmisKasayiBosalt()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                connection.Open();

                DialogResult durum = MessageBox.Show("Geçmiş tarihlerin bilgilerini silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                SqlCommand komut = new SqlCommand("DELETE FROM bilet WHERE biletSatisTarihi < CONVERT(date, GETDATE())", connection);
                if (DialogResult.Yes == durum)
                {
                   komut.ExecuteNonQuery();
                   MessageBox.Show("Geçmiş tarihler silindi.");
                }
                connection.Close();  
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kasayı boşaltma Sırasında Hata Oluştu." + hata.Message);
            }

        }
    }
}
