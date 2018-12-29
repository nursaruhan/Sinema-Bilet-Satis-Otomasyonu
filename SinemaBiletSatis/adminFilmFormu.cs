using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SinemaBiletSatis.Controller;
using SinemaBiletSatis.Modeller;
namespace SinemaBiletSatis
{
    public partial class adminFilmFormu : Form
    {
        public adminFilmFormu()
        {

            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");

        public void filmSalonSeansComboBox(ComboBox cb)
        {
            try
            {
                SqlCommand salon = new SqlCommand("SELECT * FROM salon", connection);
                salon.CommandType = CommandType.Text;
                SqlDataReader salondr;
                connection.Open();
                salondr = salon.ExecuteReader();
                while (salondr.Read())
                {
                    filmSalon.Items.Add(salondr["salonAd"]);
                }
                salondr.Close();
                SqlCommand seans = new SqlCommand("SELECT * FROM seans", connection);
                seans.CommandType = CommandType.Text;
                SqlDataReader seansdr;
                seansdr = seans.ExecuteReader();
                while (seansdr.Read())
                {
                    filmSeans.Items.Add(seansdr["seansSaat"]);
                }
                seansdr.Close();
                connection.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Combobox veri çekemedi" + hata.Message);
            }
        }
        public void filmComboBox(ComboBox cb)
        {
            try
            {
                filmler.Items.Clear();
                SqlCommand film = new SqlCommand("SELECT * FROM filmler", connection);
                film.CommandType = CommandType.Text;
                SqlDataReader filmdr;
                connection.Open();
                filmdr = film.ExecuteReader();
                while (filmdr.Read()){
                    filmler.Items.Add(filmdr["fAd"]); 
                }
                filmdr.Close();
                connection.Close(); 
            }
            catch (Exception hata)
            { 
                MessageBox.Show("Combobox veri çekemedi" + hata.Message);
            }
        }

        private void adminFilm_Load(object sender, EventArgs e)
        {
            adminFilmController filmController = new adminFilmController();
            dataGridViewFilm.DataSource = filmController.FilmleriGoster();
            dataGridViewSalonSeans.DataSource = filmController.SalonSeansGoster();
            filmSalonSeansComboBox(filmSalon);
            filmComboBox(filmler);
        }
        public void filmVeriTemizle()
        {
            fAd.Clear();
            fAfis.Clear();
            dateTimeBaslangicTarihi.Text = DateTime.Now.ToLongDateString();
            dateTimeBitisTarihi.Text = DateTime.Now.ToLongDateString();
            pictureBoxAfis.Image = null;
        }
        public void salonSeansVeriTemizle()
        {
            filmler.SelectedItem = null;
            filmSalon.SelectedItem = null;
            filmSeans.SelectedItem = null;
            secilenSalonSeansId = "-1";
        }
        private void filmKaydet_Click(object sender, EventArgs e)
        {
            adminFilmController filmController = new adminFilmController();
            Filmler film = new Filmler();
            film.FilmAdi = fAd.Text;
            film.Afis = fAfis.Text;
            film.BaslangicTarihi = dateTimeBaslangicTarihi.Value;
            film.BitisTarihi = dateTimeBitisTarihi.Value;

            if (film.FilmAdi == "" || film.Afis == "" || film.BaslangicTarihi == null || film.BitisTarihi == null)
            {
               MessageBox.Show("Film Adını ve afiş bilgilerini boş bırakmayın!");
            }
            else{
                if (film.BaslangicTarihi < film.BitisTarihi)
                {
                    filmController.FilmKaydet(film);
                    filmVeriTemizle();
                    dataGridViewFilm.DataSource = filmController.FilmleriGoster();
                    filmComboBox(filmler);
                    filmVeriTemizle();
                }   
                else
                {
                    MessageBox.Show("Başlangic ve bitiş tarihi bu şekilde seçilemez!");
                }
            }   
        }

        private void filmSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int filmID ;
        int seansID;
        int salonID ;
        int guncellenenSalonSeansId = -1;


        public void idBul()
        {

            SqlCommand sorguId = new SqlCommand("SELECT * FROM filmler, salon, seans", connection);
            sorguId.CommandType = CommandType.Text;
            SqlDataReader sorguIdDr;
            sorguIdDr = sorguId.ExecuteReader();
          
            while (sorguIdDr.Read())
            {
               
                if (filmSalon.SelectedItem.ToString() == sorguIdDr["salonAd"].ToString())
                {
                    salonID = Convert.ToInt32(sorguIdDr["salonId"]);
                }
                if (filmler.SelectedItem.ToString() == sorguIdDr["fAd"].ToString())
                {
                    filmID = Convert.ToInt32(sorguIdDr["fId"]);
                }
                if (filmSeans.SelectedItem.ToString() == sorguIdDr["seansSaat"].ToString())
                {
                    seansID = Convert.ToInt32(sorguIdDr["seansId"]);
                }
            }
            
            sorguIdDr.Close();
        }

        private void ssEkle_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            if (filmler.SelectedIndex == -1 || filmSalon.SelectedIndex == -1 || filmSeans.SelectedIndex == -1)
            {
                MessageBox.Show("Eklemek istediğiniz film bilgilerini seçin!");
            }
            else
            {
                idBul();
                adminFilmController filmController = new adminFilmController();
                guncellenenSalonSeansId = filmController.SalonSeansDoluMu(salonID, seansID);
                if (guncellenenSalonSeansId != -1)
                {
                    MessageBox.Show("Lütfen başka salon ve seans seçiniz!");
                }
                else
                {
                    SalonSeans salonSeans = new SalonSeans();
                    salonSeans.FilmID = filmID;
                    salonSeans.SalonID = salonID;
                    salonSeans.SeansID = seansID;
                    filmController.SalonSeansEkle(salonSeans);
                    dataGridViewSalonSeans.DataSource = filmController.SalonSeansGoster();
                    salonSeansVeriTemizle();
                }
            }
            connection.Close();

        }
        string secilenSalonSeansId = "-1";
        private void dataGridViewSalonSeans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenSalonSeansId = dataGridViewSalonSeans.CurrentRow.Cells[0].Value.ToString();
            filmler.Text = dataGridViewSalonSeans.CurrentRow.Cells[1].Value.ToString();
            filmSalon.Text = dataGridViewSalonSeans.CurrentRow.Cells[2].Value.ToString();
            filmSeans.Text = dataGridViewSalonSeans.CurrentRow.Cells[3].Value.ToString();
            
        }
        private void salonSeansSil_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            adminFilmController filmController = new adminFilmController();
            filmController.SalonSeansSil(secilenSalonSeansId);
            dataGridViewSalonSeans.DataSource = filmController.SalonSeansGoster();
            salonSeansVeriTemizle();
            connection.Close();
        }
        string secilenFilmId = "-1";
        private void dataGridViewFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenFilmId = dataGridViewFilm.CurrentRow.Cells[0].Value.ToString();
            fAd.Text = dataGridViewFilm.CurrentRow.Cells[1].Value.ToString();
            fAfis.Text = dataGridViewFilm.CurrentRow.Cells[2].Value.ToString();
            dateTimeBaslangicTarihi.Text = dataGridViewFilm.CurrentRow.Cells[3].Value.ToString();
            dateTimeBitisTarihi.Text = dataGridViewFilm.CurrentRow.Cells[4].Value.ToString();
            fAfis.Text = dataGridViewFilm.CurrentRow.Cells[2].Value.ToString();
            pictureBoxAfis.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAfis.ImageLocation = dataGridViewFilm.CurrentRow.Cells[2].Value.ToString();
        }
        private void filmSil_Click(object sender, EventArgs e)
        {
            adminFilmController filmController = new adminFilmController();
            filmController.FilmSil(secilenFilmId);
            dataGridViewFilm.DataSource = filmController.FilmleriGoster();
            dataGridViewSalonSeans.DataSource = filmController.SalonSeansGoster();
            filmComboBox(filmler);
            secilenFilmId = "-1";
            filmVeriTemizle();
        }
        
        private void filmGuncelle_Click(object sender, EventArgs e)
        {
            adminFilmController filmController = new adminFilmController();
            Filmler film = new Filmler();
            film.Id = secilenFilmId;
            film.FilmAdi = fAd.Text;
            film.Afis = fAfis.Text;
            film.BaslangicTarihi = dateTimeBaslangicTarihi.Value;
            film.BitisTarihi = dateTimeBitisTarihi.Value;
            if (secilenFilmId == "-1")
            {
                MessageBox.Show("Güncellemek istediğiniz filmi tablodan seçin!");
            }
            else
            {
                if (film.FilmAdi == "" || film.Afis == "" || film.BaslangicTarihi == null || film.BitisTarihi == null)
                {
                    MessageBox.Show("Film Adını ve afiş bilgilerini boş bırakmayın!");
                }
                else
                {
                    if (film.BaslangicTarihi < film.BitisTarihi)
                    {
                        filmController.FilmGuncelle(film);
                        dataGridViewFilm.DataSource = filmController.FilmleriGoster();
                        dataGridViewSalonSeans.DataSource = filmController.SalonSeansGoster();
                        filmComboBox(filmler);
                        filmVeriTemizle();
                        secilenFilmId = "-1";
                    }
                    else
                    {
                        MessageBox.Show("Başlangic ve bitiş tarihi bu şekilde seçilemez!");
                    }

                }
            }
        }


        private void salonSeansGuncelle_Click(object sender, EventArgs e)
        {
            adminFilmController filmController = new adminFilmController();
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            if (filmler.SelectedIndex == -1 || filmSalon.SelectedIndex == -1 || filmSeans.SelectedIndex == -1) { 
                 MessageBox.Show("Tablodan güncellemek istediğiniz film bilgisini seçin!");
            }
            else {
            idBul();
            SalonSeans salonSeans = new SalonSeans();
            salonSeans.Id = secilenSalonSeansId;
            salonSeans.FilmID = filmID;
            salonSeans.SeansID = seansID;
            salonSeans.SalonID = salonID;
            
            guncellenenSalonSeansId = filmController.SalonSeansDoluMu(salonID, seansID);
                if (guncellenenSalonSeansId != -1) { 
                    if (Convert.ToInt32(secilenSalonSeansId) == guncellenenSalonSeansId)//Salon Seans dolu iken sadece filmin adını değiştirmek için 
                    {
                    filmController.SalonSeansGuncelle(salonSeans);
                    MessageBox.Show("Film, Salon, Seans Güncellendi.");
                    salonSeansVeriTemizle();
                    }
                    else{
                    MessageBox.Show("Lütfen başka salon ve seans seçiniz!");
                    }
                }
                else{
                filmController.SalonSeansGuncelle(salonSeans);
                MessageBox.Show("Film, Salon, Seans Güncellendi.");
                salonSeansVeriTemizle();
                }
            dataGridViewSalonSeans.DataSource = filmController.SalonSeansGoster();           
            connection.Close();}
        }

        private void afisSec_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBoxAfis.ImageLocation = openFileDialog.FileName;
            pictureBoxAfis.SizeMode = PictureBoxSizeMode.StretchImage;
            fAfis.Text = openFileDialog.FileName;
            pictureBoxAfis.Image = null;
        }
    }
}
