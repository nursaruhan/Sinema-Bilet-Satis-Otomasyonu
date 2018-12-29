using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SinemaBiletSatis.Controller;
namespace SinemaBiletSatis
{
    public partial class CalisanAnasayfaForm : Form
    {

        SqlConnection connection = new SqlConnection("Server =.; Database=SinemaDB; trusted_connection=true");
        SqlCommand command;
        SqlDataReader reader;

        String seanssec;
        String film = null;
        String kullanicimail;
        String kullaniciAd;
        String kullaniciSoyad;
        String secilenListView;
        public DateTime Value { get; set; }
        private void CalisanAnasayfaForm_Load(object sender, EventArgs e)
        {

        }
        public CalisanAnasayfaForm(String kullanici, String kulSoyad)
        {
            InitializeComponent();

            kullanicimail = kullanici;
            connection.Open();
            command = new SqlCommand("Select * From kullanicilar where kEmail='" + kullanici + "'", connection);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                kullaniciAd = reader["kAd"].ToString();
                kullaniciSoyad = reader["kSoyad"].ToString();
                label5.Text = kullaniciAd + " " + kullaniciSoyad;
            }
            else
            {
                label5.Text = kullanici + " " + kulSoyad;
                kullaniciAd = kullanici;
                kullaniciSoyad = kulSoyad;
            }

            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            gosterimdekiFilmler();
            gosterimeGiricekFilmler();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }
        private void cıkıs_Click(object sender, EventArgs e)
        {
            LoginFormu girisedon = new LoginFormu();
            girisedon.Show();
            this.Hide();
            kullanicimail = null;
        }

        private void gosterimdekiFilmler()
        {
           
            connection.Open();
            command = new SqlCommand("select * from filmler where  CONVERT (date, GETDATE())>= baslagicTarihi and bitisTarihi > CONVERT (date, GETDATE()); ", connection);
            reader = command.ExecuteReader();
            int i = 0;
            try{
                while (reader.Read())
                {
                    ListViewItem listfilm = new ListViewItem();

                    listView1.View = View.Details;
                    listView1.Columns.Add("filmler ", 0);
                    listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView1.GridLines = false;
                    imageList1.ImageSize = new Size(115, 115);
                    imageList1.Images.Add(Image.FromFile(reader["fAfis"].ToString()));

                    listfilm.Text = reader["fAd"].ToString();
                    listView1.SmallImageList = imageList1;
                    listView1.Items.Add(listfilm.Text, i);
                    i++;
                }
            }catch(Exception hata)
            {
                MessageBox.Show("Hata oluştu. Dosya Yolunu bulamamış olabilir." + hata);
            }
            connection.Close();
        }
        private void gosterimeGiricekFilmler()
        {
            connection.Open();
            command = new SqlCommand("select * from filmler where  CONVERT (date, GETDATE())<baslagicTarihi; ", connection);
            reader = command.ExecuteReader();
            int j = 0;
            try
            {
                while (reader.Read())
                {
                    ListViewItem listfilm = new ListViewItem();

                    listView2.View = View.Details;
                    listView2.Columns.Add("gösterime girecek filmler", 0);
                    listView2.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                    listView2.GridLines = false;

                    /*  pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                      pictureBox1.Image = Image.FromFile(reader["fAfis"].ToString());/*/ //picture boxda resim gosterme
                    imageList2.ImageSize = new Size(115, 115);
                    imageList2.Images.Add(Image.FromFile(reader["fAfis"].ToString()));

                    listfilm.Text = reader["fAd"].ToString();
                    listView2.SmallImageList = imageList2;
                    listView2.Items.Add(listfilm.Text, j);
                    j++;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu. Dosya Yolunu bulamamış olabilir." + hata);
            }
            connection.Close();
        }

        private void filmsec_Click(object sender, EventArgs e)
        {    
            if (listView1.SelectedItems.Count > 0)
            {
                tarihsec.Enabled = true;
                film = listView1.SelectedItems[0].SubItems[0].Text;
                
                secilenListView = "listview1";
            }
            else if (listView2.SelectedItems.Count > 0)
            {
                tarihsec.Enabled = true;
                film = listView2.SelectedItems[0].SubItems[0].Text;
                secilenListView = "listview2";
            }
            else
            {
                MessageBox.Show("lütfen film seçiniz!");
            }
            listView2.SelectedItems.Clear();
            listView1.SelectedItems.Clear();
            dateTimePicker1.Visible = false;
            seansGoster.Enabled = false;
            dataGridView1.Visible = false;
        }
        private void tarihsec_Click(object sender, EventArgs e)
        {
            anasayfaController anasayfaController = new anasayfaController();
            DateTime baslanGun, bitisGun;
            baslanGun = anasayfaController.BasTarihGetir(film);
            bitisGun = anasayfaController.BitTarihGetir(film);
            try
            {
                if (baslanGun <= DateTime.Today)
                {
                    dateTimePicker1.MinDate = DateTime.Today;
                    dateTimePicker1.MaxDate = bitisGun;
                }
                else
                {
                    /* if(dateTimePicker1.MaxDate<baslanGun)
                     {
                         dateTimePicker1.MaxDate = bitisGun;
                     }*/
                    dateTimePicker1.MaxDate = bitisGun;
                    dateTimePicker1.MinDate = baslanGun;
                   
                }
                dateTimePicker1.Value = dateTimePicker1.MinDate;
                seansGoster.Enabled = true;
                dateTimePicker1.Visible = true;
                Controls.AddRange(new Control[] { dateTimePicker1 });
                dateTimePicker1.ForeColor = Color.Blue;
                dateTimePicker1.CalendarForeColor = Color.Black;
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata oluştur"+hata);
            } 


        }
        private void seancSec_Click(object sender, EventArgs e)
        {
            anasayfaController anasayfaControl = new anasayfaController();
            if (secilenListView == "listview1" && DateTime.Today == Convert.ToDateTime(dateTimePicker1.Value))
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = anasayfaControl.bugunkiseaslar(film);
            }
            else if (secilenListView == "listview2" || secilenListView == "listview1")
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = anasayfaControl.gelecekGundekiSeanslar(film);
            }
            else
            {
                MessageBox.Show("salon ve seans bilgisi getirilemedi");
            }
            if (dataGridView1.Rows.Count > 0)
            {
                salonagec.Visible = true;
            }
            else
            {
                MessageBox.Show("ilgili film ve tarih bilgisine göre seans yoktur.");
            }
        }
        private void salonaGit_Click(object sender, EventArgs e)
        {
            String salonNo = null;
            DateTime seciligun = Convert.ToDateTime(dateTimePicker1.Value); //secili gun alma  
            if (dataGridView1.Rows.Count > 0)
            {
                seanssec = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //secilmis seans saaati
                salonNo = dataGridView1.CurrentRow.Cells[0].Value.ToString();  //secilmis salon no bilgisi
            }
            else
            {
                MessageBox.Show("secili film ve tarih bilgisine göre seans bulunamadı");
            }
            if (film != null && salonNo != null && kullaniciAd != null && kullaniciSoyad != null)
            {
                salonForm koltukgoster = new salonForm(film, salonNo, seanssec, seciligun, kullaniciAd, kullaniciSoyad);//seans ıd,filmadi
                koltukgoster.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("lütfen gerekli bilgileri seçiniz!");
            }
            // Application.Exit();
        }
        private void biletDuzenle_Click(object sender, EventArgs e)
        {
            biletDegisiklikForm rezerve = new biletDegisiklikForm(kullaniciAd, kullaniciSoyad);
            rezerve.Show();
            this.Hide();
        }


    }
}
