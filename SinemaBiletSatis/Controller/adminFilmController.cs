using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaBiletSatis.Modeller;

namespace SinemaBiletSatis.Controller
{
    class adminFilmController
    {
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

        public DataTable FilmleriGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from filmler", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable SalonSeansGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT salonSeansId, fAd, salonAd, seansSaat FROM filmler, salon, seans, salonSeans  WHERE salon.salonId = salonSeans.salonId AND seans.seansId = salonSeans.seansId AND filmler.fId = salonSeans.fId", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void FilmKaydet(Filmler film)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string kayit = "INSERT INTO filmler(fAd,fAfis,baslagicTarihi,bitisTarihi) values (@fAd,@fAfis,@baslagicTarihi,@bitisTarihi)";
                SqlCommand komut = new SqlCommand(kayit, connection);
                komut.Parameters.AddWithValue("@fAd", film.FilmAdi);
                komut.Parameters.AddWithValue("@fAfis", film.Afis);
                komut.Parameters.AddWithValue("@baslagicTarihi", film.BaslangicTarihi);
                komut.Parameters.AddWithValue("@bitisTarihi", film.BitisTarihi);
                komut.ExecuteNonQuery();
                MessageBox.Show("Yeni film eklendi.");
                komut.Dispose();
                connection.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        public void FilmGuncelle(Filmler film)
        {
            try
            {
                if (connection.State == ConnectionState.Closed){
                    connection.Open();
                }
                if (film.Id == "-1"){
                    MessageBox.Show("Tablodan güncellemek istediğiniz filmi seçiniz.");
                }
                else
                {
                    DialogResult durum = MessageBox.Show(film.Id + ". filmi güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
                    SqlCommand cmd = new SqlCommand("UPDATE filmler SET fAd=@fAd, fAfis=@fAfis, baslagicTarihi=@baslagicTarihi, bitisTarihi=@bitisTarihi WHERE fId=(" + film.Id + ")", connection);
                    cmd.Parameters.AddWithValue("@fAd", film.FilmAdi);
                    cmd.Parameters.AddWithValue("@fAfis", film.Afis);
                    cmd.Parameters.AddWithValue("@baslagicTarihi", film.BaslangicTarihi);
                    cmd.Parameters.AddWithValue("@bitisTarihi", film.BitisTarihi);

                    if (DialogResult.Yes == durum)
                    {
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Film Bilgisi Güncellendi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata olustu!" + hata.Message);
            }
        }
        public void FilmSil(string secilenFilmId)
        {
            try
            {
                if (connection.State == ConnectionState.Closed){
                    connection.Open();
                }
                if (secilenFilmId == "-1")
                {
                    MessageBox.Show("Tablodan silmek istediğiniz filmi seçiniz.");
                }
                else
                {
                    DialogResult durum = MessageBox.Show(secilenFilmId + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    SqlCommand komutSilSalonSeans = new SqlCommand(" DELETE FROM salonSeans  WHERE fId = (" + secilenFilmId + ")", connection);
                    SqlCommand komutSilFilm = new SqlCommand(" DELETE FROM filmler  WHERE fId = (" + secilenFilmId + ")", connection);
                    if (DialogResult.Yes == durum)
                    {
                        komutSilSalonSeans.ExecuteNonQuery();
                        komutSilFilm.ExecuteNonQuery();
                        MessageBox.Show("Film silindi.Filmin gösterildiği salon ve seans boşaltıldı.");
                    }
                    connection.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme işlemi Sırasında Hata Oluştu." + hata.Message);
            }
        }
        public void SalonSeansEkle(SalonSeans salonSeans)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string kayit = "INSERT INTO salonSeans(fId,seansId,salonId) values (@fId, @seansId ,@salonId)";
                SqlCommand komut = new SqlCommand(kayit, connection);
                komut.Parameters.AddWithValue("@fId", salonSeans.FilmID);
                komut.Parameters.AddWithValue("@seansId", salonSeans.SeansID);
                komut.Parameters.AddWithValue("@salonId", salonSeans.SalonID);
                komut.ExecuteNonQuery();
                komut.Dispose();
                MessageBox.Show("Salon seans eklendi");
               // connection.Close();  
            }
            catch (Exception hata)
            {
                connection.Close();
                MessageBox.Show("Film, Salon, Seans bilgilerini seçip tekrar deneyin Hata:" + hata.Message);
            }
        }
        public void SalonSeansSil(string secilenSalonSeansId)
        {
            try
            {
                if (secilenSalonSeansId == "-1")
                {
                    MessageBox.Show("Tablodan silmek istediğiniz veriyi seçiniz.");
                }
                else
                {
                    DialogResult durum = MessageBox.Show(secilenSalonSeansId + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    connection.Open();
                    SqlCommand komutSil = new SqlCommand(" DELETE FROM salonSeans WHERE salonSeansId = (" + secilenSalonSeansId + ")", connection);
                    if (DialogResult.Yes == durum)
                    {
                        komutSil.ExecuteNonQuery();    
                        MessageBox.Show("Salon seans silindi");
                    }
                    //connection.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme işlemi Sırasında Hata Oluştu." + hata.Message);
            }

        }
        public void SalonSeansGuncelle(SalonSeans salonSeans) {
            try{
                if (connection.State == ConnectionState.Closed){
                    connection.Open();
                }
                if (salonSeans.Id == "-1"){
                    MessageBox.Show("Tablodan güncellemek istediğiniz filmi seçiniz.");
                }
                else
                {
                    DialogResult durum = MessageBox.Show(salonSeans.Id + ". veriyi güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);

                    SqlCommand cmd = new SqlCommand("UPDATE salonSeans SET fId=@fId, seansId=@seansId, salonId=@salonId WHERE salonSeansId=(" + salonSeans.Id + ")", connection);
                    cmd.Parameters.AddWithValue("@fId", salonSeans.FilmID);
                    cmd.Parameters.AddWithValue("@seansId", salonSeans.SeansID);
                    cmd.Parameters.AddWithValue("@salonId", salonSeans.SalonID);
                    
                    if (DialogResult.Yes == durum){
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata olustu!" + hata.Message);
            }
        }

        public int SalonSeansDoluMu(int salonID, int seansID)
        {
            connection.Open();
            SqlCommand sorguDoluMu = new SqlCommand("SELECT * FROM salonSeans", connection);
            sorguDoluMu.CommandType = CommandType.Text;
            SqlDataReader sorguDoluMuDr;
            sorguDoluMuDr = sorguDoluMu.ExecuteReader();
            int secilenSalonSeansId = -1;
            while (sorguDoluMuDr.Read())
            {
                if (Convert.ToInt32(sorguDoluMuDr["salonId"]) == salonID &&
                    Convert.ToInt32(sorguDoluMuDr["seansId"]) == seansID)
                {
                    secilenSalonSeansId = Convert.ToInt32(sorguDoluMuDr["salonSeansId"]);
                    sorguDoluMuDr.Close();
                    return secilenSalonSeansId;
                }

            }
            sorguDoluMuDr.Close();
            return secilenSalonSeansId;
        }
    }
}
