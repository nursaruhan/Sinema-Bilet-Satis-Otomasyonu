using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SinemaBiletSatis.Controller
{
    class loginController
    {
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

        public int girisYapKontrol(string email, string parola)
        {
            SqlCommand command;
            SqlDataReader reader;
            connection.Open();
            command = new SqlCommand("Select * From kullanicilar where kEmail='" + email + "' and kParola='" + parola + "'", connection);
            var login = new LoginFormu();
            reader = command.ExecuteReader();
            int donusDeger;

            if (reader.Read())
            {
                if (reader["kYetki"].ToString() == "0")
                {
                    donusDeger = 0;
                    return donusDeger;

                }
                else
                {
                    donusDeger = 1;
                    return donusDeger;
                }
            }
            else
            {
                donusDeger = 2;
                return donusDeger;
            }
        }  
    }
}