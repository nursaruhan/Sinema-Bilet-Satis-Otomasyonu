using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaBiletSatis.Modeller;

namespace SinemaBiletSatis.Controller
{
    class adminKullaniciController
    {
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

        public DataTable KullanicilariGoster()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from kullanicilar", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        
        public  bool EmailFormatKontrol(string email)
        {
            string pattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Email Formatını Doğru Girin ");
                return false;
            }
        }
        public void KullaniciEkle(Kullanicilar kullanici)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO kullanicilar(kTc, kAd, kSoyad, kEmail, kParola, kYetki) values ('"
                    + kullanici.Tc + "','" + kullanici.Adi + "','" + kullanici.Soyadi + "','" + kullanici.Email + "','" + kullanici.Parola + "','" + kullanici.Yetki+"')", connection);
                komut.ExecuteNonQuery();
                komut.Dispose();
                connection.Close();
                MessageBox.Show("Yeni kullanıcı eklendi.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        public void KullaniciSil(string secilenKullaniciId)
        {
            try
            {
                if (connection.State == ConnectionState.Closed){
                    connection.Open();
                }
                if (secilenKullaniciId == "-1"){
                    MessageBox.Show("Tablodan silmek istediğiniz kullanıcıyı seçiniz.");
                }
                else{
                    DialogResult durum = MessageBox.Show(secilenKullaniciId + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    SqlCommand komutSil = new SqlCommand(" DELETE FROM kullanicilar  WHERE kId = (" + secilenKullaniciId + ")", connection);
                    if (DialogResult.Yes == durum){
                        komutSil.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı Silindi.");
                    }
                    connection.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme işlemi Sırasında Hata Oluştu." + hata.Message);
            }
        }

        public void KullaniciGuncelle(Kullanicilar kullanici)
        {
            try{
                if (connection.State == ConnectionState.Closed){
                    connection.Open();
                }
                if (kullanici.Id == "-1"){
                    MessageBox.Show("Tablodan güncellemek istediğiniz kullanıcıyı seçiniz.");
                }
                else
                {
                    DialogResult durum = MessageBox.Show(kullanici.Id + ". kullanıcının bilgisini güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo);
                    SqlCommand komutGuncelle = new SqlCommand("UPDATE kullanicilar SET kTc=@tc, kAd=@ad, kSoyad=@soyad, kEmail=@email, kParola=@parola, kYetki=@yetki " +
                                                               "WHERE kId=(" + kullanici.Id + ")", connection);
                    komutGuncelle.Parameters.AddWithValue("@tc", kullanici.Tc);
                    komutGuncelle.Parameters.AddWithValue("@ad", kullanici.Adi);
                    komutGuncelle.Parameters.AddWithValue("@soyad", kullanici.Soyadi);
                    komutGuncelle.Parameters.AddWithValue("@email", kullanici.Email);
                    komutGuncelle.Parameters.AddWithValue("@parola", kullanici.Parola);
                    komutGuncelle.Parameters.AddWithValue("@yetki", kullanici.Yetki);
                    if (DialogResult.Yes == durum)
                    {
                        komutGuncelle.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Kullanıcı Bilgisi Güncellendi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata olustu!" + hata.Message);
            }
        }

    }
}
