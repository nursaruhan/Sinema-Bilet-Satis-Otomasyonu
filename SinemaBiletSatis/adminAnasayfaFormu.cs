using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace SinemaBiletSatis
{
    public partial class adminAnasayfaFormu : Form
    {
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
        public adminAnasayfaFormu(String email)
        {
            InitializeComponent();

     
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From kullanicilar where kEmail='" + email + "'", connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
            
                kullanıcıAdSoyad.Text = reader["kAd"].ToString() + " " + reader["kSoyad"].ToString();
            }
 
            connection.Close();
        }

        private void adminAnasayfa_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32DLL", EntryPoint = "RelaaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void gecis(object adminAnasayfa)
        {
            if (this.arkaPanel.Controls.Count > 0)
                this.arkaPanel.Controls.RemoveAt(0);
            Form form = adminAnasayfa as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.arkaPanel.Controls.Add(form);
            this.arkaPanel.Tag = form;
            form.Show();
        }

        private void filmBilgi_Click(object sender, EventArgs e)
        {
            gecis(new adminFilmFormu());
        }

        private void kullanicilarBilgi_Click(object sender, EventArgs e)
        {
            gecis(new adminKullaniciFormu());
        }

        private void biletBilgi_Click(object sender, EventArgs e)
        {
            gecis(new adminBiletFormu());
        }

        private void cıkıs_Click(object sender, EventArgs e)
        {
            LoginFormu logineDon = new LoginFormu();
            logineDon.Show();
            this.Hide();
        }

        private void arkaPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
