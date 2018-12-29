using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBiletSatis.Controller
{
    class salonController
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
            con.Open();
            return con;
        }

        public static String[] satilmisKoltuklar(int seansId, int salonId, int filmId, DateTime seciligun)
        {
            String koltuk;
            int koltukno;
            String[] Dolukoltuk = new String[37];

            SqlCommand command = new SqlCommand("select koltukId from bilet where  biletDurumu='satıldı' and seansId='" + seansId + "'  and salonId='" + salonId + "' and fId='" + filmId + "' and filmGun='" + seciligun.ToString("yyyy-MM-dd") + "'", GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                koltuk = reader["koltukId"].ToString();
                koltukno = int.Parse(koltuk);
                Dolukoltuk[koltukno] = "button" + reader["koltukId"].ToString();
            }
            return Dolukoltuk;
        }
        public static String[] rezerveKoltuklar(int seansId, int salonId, int filmId, DateTime seciligun)
        {
            String[] rezervekoltuk = new string[37];
            String koltukrezerve;
            int koltukrezerveno;
            SqlCommand command = new SqlCommand("select koltukId from bilet where  biletDurumu='rezerve' and seansId='" + seansId + "'  and salonId='" + salonId + "' and fId='" + filmId + "' AND filmGun='" + seciligun.ToString("yyyy-MM-dd") + "'", GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                koltukrezerve = reader["koltukId"].ToString();
                koltukrezerveno = int.Parse(koltukrezerve);
                rezervekoltuk[koltukrezerveno] = "button" + reader["koltukId"].ToString();
            }
            return rezervekoltuk;
        }
    }
}
