using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SinemaBiletSatis.Modeller;

namespace SinemaBiletSatis.Controller
{
    class biletcontroller
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

            con.Open();
            return con;
        }

        public void biletEkle(Bilet bilet)
        {

            SqlCommand komut = new SqlCommand("INSERT INTO bilet(biletSatisTarihi,biletDurumu,seyirciAd,seyirciSoyad,odemeTuru,kId,koltukId,seansId,salonId,ucretId,fId,filmGun,kisiUcreti) values (@biletSatisTarihi,@biletDurumu,@seyirciAd,@seyirciSoyad,@odemeTuru,@kId,@koltukId,@seansId,@salonId,@ucretId,@fId,@filmGun,@kisiUcreti)", GetConnection());
            komut.Parameters.AddWithValue("@biletSatisTarihi", bilet.biletSatisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@biletDurumu", bilet.biletDurumu);
            komut.Parameters.AddWithValue("@seyirciAd", bilet.seyirciAd);
            komut.Parameters.AddWithValue("@seyirciSoyad", bilet.seyirciSoyad);
            komut.Parameters.AddWithValue("@odemeTuru", bilet.odemeTuru);
            komut.Parameters.AddWithValue("@kId", bilet.kId);
            komut.Parameters.AddWithValue("@koltukId", bilet.koltukId);
            komut.Parameters.AddWithValue("@seansId", bilet.seansId);
            komut.Parameters.AddWithValue("@salonId", bilet.salonId);
            komut.Parameters.AddWithValue("@ucretId", bilet.ucretId);
            komut.Parameters.AddWithValue("@fId", bilet.fId);
            komut.Parameters.AddWithValue("@filmGun", bilet.filmgun);
            komut.Parameters.AddWithValue("@kisiUcreti", bilet.kisiUcreti);
            komut.ExecuteNonQuery();
            komut.Dispose();
        }
        public void biletSilFonk(int biletid)
        {
            SqlCommand sil = new SqlCommand("delete from bilet where biletId='" + biletid + "'", GetConnection());
            sil.ExecuteNonQuery();
        }
        public void rezervesilFonk(int biletid)
        {
            SqlCommand sil = new SqlCommand("delete from bilet where biletId='" + biletid + "'", GetConnection());
            sil.ExecuteNonQuery();
        }
        public void rezerveSatFonk(Bilet bilet)
        {
            SqlCommand command = new SqlCommand("UPDATE bilet SET biletDurumu=@biletDurumu, ucretId=@ucretId, odemeTuru=@odemeTuru ,kisiUcreti=@kisiUcreti ,biletSatisTarihi=@tarih,kId=@kid WHERE biletId='" + bilet.biletId + "'", GetConnection());
            command.Parameters.AddWithValue("@biletDurumu", "satıldı");
            command.Parameters.AddWithValue("@odemeTuru", bilet.odemeTuru);
            command.Parameters.AddWithValue("@ucretId", bilet.ucretId);
            command.Parameters.AddWithValue("@kisiUcreti", bilet.kisiUcreti);
            command.Parameters.AddWithValue("@tarih", DateTime.Today);
            command.Parameters.AddWithValue("@kid", bilet.kId);

            command.ExecuteNonQuery();
        }
    }
}
