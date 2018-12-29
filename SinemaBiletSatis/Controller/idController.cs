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
    class idController
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

            con.Open();
            return con;
        }
        public int koltukIdGetir(String koltukno)
        {
            String koltukId = "0";
            int koltukIdDondur;

            SqlCommand command = new SqlCommand("SELECT * FROM koltuk where koltukHarfNumara='" + koltukno + "'", GetConnection());
            command.CommandType = CommandType.Text;


            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                koltukId = reader["koltukId"].ToString();
            }


            koltukIdDondur = int.Parse(koltukId);
            return koltukIdDondur;
        }
        public int fIdGetir(String filmad)
        {
            String filmId = "0";
            int filmIdDondur;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM filmler where fAd='" + filmad + "'", GetConnection());
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    filmId = reader["fId"].ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu:" + hata.Message);
            }
            filmIdDondur = int.Parse(filmId);
            return filmIdDondur;
        }
        public int kIdGetir(String kullaniciad, String kullanicisoyad)
        {
            String kullaniciId = "0";
            int kullaniciIdDondur;

            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM kullanicilar where kAd='" + kullaniciad + "'and kSoyad='" + kullanicisoyad + "'", GetConnection());
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kullaniciId = reader["kId"].ToString();
                }
                reader.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu:" + hata.Message);
            }
            kullaniciIdDondur = int.Parse(kullaniciId);
            return kullaniciIdDondur;
        }
        public int salonIdGetir(String salonad)
        {
            String salonId = "0";
            int salonIdDondur;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM salon where salonAd='" + salonad + "'", GetConnection());
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    salonId = reader["salonId"].ToString();
                }
            }
            catch (Exception hata) {
                MessageBox.Show("Hata Oluştu:" + hata.Message);
            }
            salonIdDondur = int.Parse(salonId);
            return salonIdDondur;
        }
        public int seansIdGetir(String seanssaati)
        {
            String seansId = "0";
            int seansIdDondur;
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM seans where seansSaat='" + seanssaati + "'", GetConnection());
                command.CommandType = CommandType.Text;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    seansId = reader["seansId"].ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu:" + hata.Message);
            }
            seansIdDondur = int.Parse(seansId);
            return seansIdDondur;
        }
        public int ucretIdGetir(String ucretad)
        {
            String ucretId = "0";
            int ucretIdDondur;
            SqlCommand command = new SqlCommand("SELECT * FROM ucret where ucretAd='" + ucretad + "'", GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ucretId = reader["ucretId"].ToString();

            }
            ucretIdDondur = int.Parse(ucretId);
            return ucretIdDondur;
        }
        public int fiyatGetir(String ucretad)
        {
            String ucretId = "0";
            int ucretIdDondur;
            SqlCommand command = new SqlCommand("SELECT * FROM ucret where ucretAd='" + ucretad + "'", GetConnection());
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ucretId = reader["ucretFiyat"].ToString();

            }

            ucretIdDondur = int.Parse(ucretId);
            return ucretIdDondur;
        }
    }
}
