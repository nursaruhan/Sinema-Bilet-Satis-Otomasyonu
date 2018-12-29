using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis.Controller
{
    class anasayfaController
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

            con.Open();
            return con;
        }


        public DateTime BasTarihGetir(String film)
        {
            String baslangictarih, bitistarih;
            DateTime basTarih = DateTime.Today, bitTarih;
            SqlCommand command = new SqlCommand("Select * From filmler where fAd = '" + film + "' ", GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                baslangictarih = reader["baslagicTarihi"].ToString();
                bitistarih = reader["bitisTarihi"].ToString();
                basTarih = DateTime.Parse(baslangictarih);
                bitTarih = DateTime.Parse(bitistarih);
            }
            return basTarih;
        }
        public DateTime BitTarihGetir(String film)
        {
            String bitistarih;
            DateTime bitTarih = DateTime.Today;
            SqlCommand command = new SqlCommand("Select * From filmler where fAd = '" + film + "' ", GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                bitistarih = reader["bitisTarihi"].ToString();
                bitTarih = DateTime.Parse(bitistarih);
            }
            return bitTarih;
        }
        public DataTable bugunkiseaslar(String film)
        {
            int id;
            idController filmId = new idController();
            id = filmId.fIdGetir(film);
            SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT  dbo.salon.salonAd, dbo.seans.seansSaat FROM dbo.filmler INNER JOIN dbo.salonSeans ON dbo.filmler.fId = dbo.salonSeans.fId INNER JOIN dbo.seans ON dbo.salonSeans.seansId = dbo.seans.seansId INNER JOIN dbo.salon ON dbo.salonSeans.salonId = dbo.salon.salonId and CONVERT (time, GETDATE()) <=  dbo.seans.seansSaat and dbo.salonSeans.fId = '" + id + "'", connection);
            //getcurrent kucuktur olucak normalde
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable gelecekGundekiSeanslar(String film)
        {
            int id;
            idController filmId = new idController();
            id=filmId.fIdGetir(film);
            SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
            SqlDataAdapter da = new SqlDataAdapter("SELECT  dbo.salon.salonAd, dbo.seans.seansSaat FROM dbo.filmler INNER JOIN dbo.salonSeans ON dbo.filmler.fId = dbo.salonSeans.fId INNER JOIN dbo.seans ON dbo.salonSeans.seansId = dbo.seans.seansId INNER JOIN dbo.salon ON dbo.salonSeans.salonId = dbo.salon.salonId  and dbo.salonSeans.fId ='" + id + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

    }
}
