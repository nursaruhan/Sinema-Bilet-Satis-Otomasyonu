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
    public partial class salonForm : Form
    {
        String[] secilenkoltuklar = new string[36]; //secili koltuklar icin dizi olusturma
        String film;
        DateTime seciligun;
        String kuAd;
        String kuSoyad;
        int eklefilmId, eklekullaniciId, ekleseansId, eklesalonId;
        String[] Dolukoltuk = new String[37];
        String[] rezervekoltuk = new String[37];
        idController idController = new idController();

        public salonForm(String filmadi, String salonNo, String seanssaati, DateTime secigun, String kullanAd, String kullanSoyad)
        {
            InitializeComponent();

            film = filmadi;
            seciligun = secigun;
            kuAd = kullanAd;
            kuSoyad = kullanSoyad;
            label6.Text = kuAd + " " + kuSoyad;
            label8.Text = salonNo;
            label11.Text = seanssaati;
            label10.Text = film;
            label13.Text = secigun.ToString();

            eklekullaniciId = idController.kIdGetir(kuAd, kuSoyad);
            eklefilmId = idController.fIdGetir(film);
            eklesalonId = idController.salonIdGetir(label8.Text);
            ekleseansId = idController.seansIdGetir(label11.Text);
        }

        private void salonkoltuk_Load(object sender, EventArgs e)
        {
            timer1.Start();

            Dolukoltuk = salonController.satilmisKoltuklar(ekleseansId, eklesalonId, eklefilmId, seciligun);
            kirmiziyacevirme();

            rezervekoltuk = salonController.rezerveKoltuklar(ekleseansId, eklesalonId, eklefilmId, seciligun);
            ligtblueyacevirme();
        }
        private void form2yegecis_Click(object sender, EventArgs e)
        {
            CalisanAnasayfaForm kullaniciForm = new CalisanAnasayfaForm(kuAd, kuSoyad); //kullanici adsoyad gonderme
            kullaniciForm.Show();
            this.Hide();
        }
        private void button37_Click(object sender, EventArgs e)
        {
            int secilmiskoltuksayisi = 0;
            for (int i = 0; i < 36; i++)
            {
                if (secilenkoltuklar[i] != null)
                {
                    secilmiskoltuksayisi++;
                }
            }
            if (film != null && label8.Text != null && label11.Text != null && kuAd != null && kuSoyad != null)
            {
                if (secilmiskoltuksayisi != 0)
                {
                    YeniBiletForm biletsatma = new YeniBiletForm(film, label8.Text, label11.Text, secilenkoltuklar, seciligun, kuAd, kuSoyad); //label8 salonad ,label11 seans saati
                    biletsatma.Show();
                    this.Hide();//Application.Exit()
                }
                else
                {
                    MessageBox.Show("lütfen koltuk seçiniz! Koltuk seçimi yapmadınız.");
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red || button1.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button1.BackColor == Color.Green)
            {
                button1.BackColor = Color.White;
                secilenkoltuklar[0] = null;
            }
            else
            {
                button1.BackColor = Color.Green;
                secilenkoltuklar[0] = "A" + button1.Text;

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Red || button2.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button2.BackColor == Color.Green)
            {
                button2.BackColor = Color.White;
                secilenkoltuklar[1] = null;
            }
            else
            {
                button2.BackColor = Color.Green;
                secilenkoltuklar[1] = "A" + button2.Text;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red || button3.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else
            if (button3.BackColor == Color.Green)
            {
                button3.BackColor = Color.White;
                secilenkoltuklar[2] = null;
            }
            else
            {
                button3.BackColor = Color.Green;
                secilenkoltuklar[2] = "A" + button3.Text;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Red || button4.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button4.BackColor == Color.Green)
            {
                button4.BackColor = Color.White;
                secilenkoltuklar[3] = null;
            }
            else
            {
                button4.BackColor = Color.Green;
                secilenkoltuklar[3] = "A" + button4.Text;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.Red || button5.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button5.BackColor == Color.Green)
            {
                button5.BackColor = Color.White;
                secilenkoltuklar[4] = null;
            }
            else
            {
                button5.BackColor = Color.Green;
                secilenkoltuklar[4] = "A" + button5.Text;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Red || button6.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button6.BackColor == Color.Green)
            {
                button6.BackColor = Color.White;
                secilenkoltuklar[5] = null;
            }
            else
            {
                button6.BackColor = Color.Green;
                secilenkoltuklar[5] = "A" + button6.Text;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Red || button7.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button7.BackColor == Color.Green)
            {
                button7.BackColor = Color.White;
                secilenkoltuklar[6] = null;
            }
            else
            {
                button7.BackColor = Color.Green;
                secilenkoltuklar[6] = "A" + button7.Text;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.Red || button8.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button8.BackColor == Color.Green)
            {
                button8.BackColor = Color.White;
                secilenkoltuklar[7] = null;
            }
            else
            {
                button8.BackColor = Color.Green;
                secilenkoltuklar[7] = "A" + button8.Text;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.Red || button9.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button9.BackColor == Color.Green)
            {
                button9.BackColor = Color.White;
                secilenkoltuklar[8] = null;
            }
            else
            {
                button9.BackColor = Color.Green;
                secilenkoltuklar[8] = "B" + button9.Text;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.Red || button10.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button10.BackColor == Color.Green)
            {
                button10.BackColor = Color.White;
                secilenkoltuklar[9] = null;
            }
            else
            {
                button10.BackColor = Color.Green;
                secilenkoltuklar[9] = "B" + button10.Text;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.Red || button11.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button11.BackColor == Color.Green)
            {
                button11.BackColor = Color.White;
                secilenkoltuklar[10] = null;
            }
            else
            {
                button11.BackColor = Color.Green;
                secilenkoltuklar[10] = "B" + button11.Text;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.Red || button12.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button12.BackColor == Color.Green)
            {
                button12.BackColor = Color.White;
                secilenkoltuklar[11] = null;
            }
            else
            {
                button12.BackColor = Color.Green;
                secilenkoltuklar[11] = "B" + button12.Text;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.Red || button13.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button13.BackColor == Color.Green)
            {
                button13.BackColor = Color.White;
                secilenkoltuklar[12] = null;
            }
            else
            {
                button13.BackColor = Color.Green;
                secilenkoltuklar[12] = "B" + button13.Text;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.Red || button14.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button14.BackColor == Color.Green)
            {
                button14.BackColor = Color.White;
                secilenkoltuklar[13] = null;
            }
            else
            {
                button14.BackColor = Color.Green;
                secilenkoltuklar[13] = "B" + button14.Text;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.Red || button15.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button15.BackColor == Color.Green)
            {
                button15.BackColor = Color.White;
                secilenkoltuklar[14] = null;
            }
            else
            {
                button15.BackColor = Color.Green;
                secilenkoltuklar[14] = "B" + button15.Text;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Red || button16.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button16.BackColor == Color.Green)
            {
                button16.BackColor = Color.White;
                secilenkoltuklar[15] = null;
            }
            else
            {
                button16.BackColor = Color.Green;
                secilenkoltuklar[15] = "C" + button16.Text;
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Red || button17.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button17.BackColor == Color.Green)
            {
                button17.BackColor = Color.White;
                secilenkoltuklar[16] = null;
            }
            else
            {
                button17.BackColor = Color.Green;
                secilenkoltuklar[16] = "C" + button17.Text;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.Red || button18.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button18.BackColor == Color.Green)
            {
                button18.BackColor = Color.White;
                secilenkoltuklar[17] = null;
            }
            else
            {
                button18.BackColor = Color.Green;
                secilenkoltuklar[17] = "C" + button18.Text;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.Red || button19.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button19.BackColor == Color.Green)
            {
                button19.BackColor = Color.White;
                secilenkoltuklar[18] = null;
            }
            else
            {
                button19.BackColor = Color.Green;
                secilenkoltuklar[18] = "C" + button19.Text;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.Red || button20.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button20.BackColor == Color.Green)
            {
                button20.BackColor = Color.White;
                secilenkoltuklar[19] = null;
            }
            {
                button20.BackColor = Color.Green;
                secilenkoltuklar[19] = "C" + button20.Text;
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == Color.Red || button21.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button21.BackColor == Color.Green)
            {
                button21.BackColor = Color.White;
                secilenkoltuklar[20] = null;
            }
            else
            {
                button21.BackColor = Color.Green;
                secilenkoltuklar[20] = "C" + button21.Text;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == Color.Red || button22.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button22.BackColor == Color.Green)
            {
                button22.BackColor = Color.White;
                secilenkoltuklar[21] = null;
            }
            else
            {
                button22.BackColor = Color.Green;
                secilenkoltuklar[21] = "C" + button22.Text;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.BackColor == Color.Red || button23.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button23.BackColor == Color.Green)
            {
                button23.BackColor = Color.White;
                secilenkoltuklar[22] = null;
            }
            else
            {
                button23.BackColor = Color.Green;
                secilenkoltuklar[22] = "D" + button23.Text;
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == Color.Red || button24.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button24.BackColor == Color.Green)
            {
                button24.BackColor = Color.White;
                secilenkoltuklar[23] = null;
            }
            else
            {
                button24.BackColor = Color.Green;
                secilenkoltuklar[23] = "D" + button24.Text;
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Red || button25.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button25.BackColor == Color.Green)
            {
                button25.BackColor = Color.White;
                secilenkoltuklar[24] = null;
            }
            else
            {
                button25.BackColor = Color.Green;
                secilenkoltuklar[24] = "D" + button25.Text;
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == Color.Red || button26.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button26.BackColor == Color.Green)
            {
                button26.BackColor = Color.White;
                secilenkoltuklar[25] = null;
            }
            else
            {
                button26.BackColor = Color.Green;
                secilenkoltuklar[25] = "D" + button26.Text;
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.Red || button27.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button27.BackColor == Color.Green)
            {
                button27.BackColor = Color.White;
                secilenkoltuklar[26] = null;
            }
            else
            {
                button27.BackColor = Color.Green;
                secilenkoltuklar[26] = "D" + button27.Text;
            }
        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.Red || button28.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button28.BackColor == Color.Green)
            {
                button28.BackColor = Color.White;
                secilenkoltuklar[27] = null;
            }
            else
            {
                button28.BackColor = Color.Green;
                secilenkoltuklar[27] = "D" + button28.Text;
            }
        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == Color.Red || button29.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button29.BackColor == Color.Green)
            {
                button29.BackColor = Color.White;
                secilenkoltuklar[28] = null;
            }
            else
            {
                button29.BackColor = Color.Green;
                secilenkoltuklar[28] = "D" + button29.Text;
            }
        }
        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == Color.Red || button30.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button30.BackColor == Color.Green)
            {
                button30.BackColor = Color.White;
                secilenkoltuklar[29] = null;
            }
            else
            {
                button30.BackColor = Color.Green;
                secilenkoltuklar[29] = "E" + button30.Text;
            }
        }
        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == Color.Red || button31.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button31.BackColor == Color.Green)
            {
                button31.BackColor = Color.White;
                secilenkoltuklar[30] = null;
            }
            else
            {
                button31.BackColor = Color.Green;
                secilenkoltuklar[30] = "E" + button31.Text;
            }
        }
        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == Color.Red || button32.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button32.BackColor == Color.Green)
            {
                button32.BackColor = Color.White;
                secilenkoltuklar[31] = null;
            }
            else
            {
                button32.BackColor = Color.Green;
                secilenkoltuklar[31] = "E" + button32.Text;
            }
        }
        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == Color.Red || button33.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button33.BackColor == Color.Green)
            {
                button33.BackColor = Color.White;
                secilenkoltuklar[32] = null;
            }
            else
            {
                button33.BackColor = Color.Green;
                secilenkoltuklar[32] = "E" + button33.Text;
            }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.BackColor == Color.Red || button34.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button34.BackColor == Color.Green)
            {
                button34.BackColor = Color.White;
                secilenkoltuklar[33] = null;
            }
            else
            {
                button34.BackColor = Color.Green;
                secilenkoltuklar[33] = "E" + button34.Text;
            }
        }
        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.BackColor == Color.Red || button35.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button35.BackColor == Color.Green)
            {
                button35.BackColor = Color.White;
                secilenkoltuklar[34] = null;
            }
            else
            {
                button35.BackColor = Color.Green;
                secilenkoltuklar[34] = "E" + button35.Text;
            }
        }
        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == Color.Red || button36.BackColor == Color.LightBlue)
            {
                MessageBox.Show("bu koltuk doludur.Lütfen başka koltuk seçiniz!");
            }
            else if (button36.BackColor == Color.Green)
            {
                button36.BackColor = Color.White;
                secilenkoltuklar[35] = null;
            }
            else
            {
                button36.BackColor = Color.Green;
                secilenkoltuklar[35] = "E" + button36.Text;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToLongDateString();
            label9.Text = DateTime.Now.ToLongTimeString();
        }

        public void kirmiziyacevirme()
        {
            int i = 1;
            if (Dolukoltuk[i] == "button1")
            {
                button1.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button2")
            {
                button2.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button3")
            {
                button3.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button4")
            {
                button4.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button5")
            {
                button5.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button6")
            {
                button6.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button7")
            {
                button7.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button8")
            {
                button8.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button9")
            {
                button9.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button10")
            {
                button10.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button11")
            {
                button11.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button12")
            {
                button12.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button13")
            {
                button13.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button14")
            {
                button14.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button15")
            {
                button15.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button16")
            {
                button16.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button17")
            {
                button17.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button18")
            {
                button18.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button19")
            {
                button19.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button20")
            {
                button20.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button21")
            {
                button21.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button22")
            {
                button22.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button23")
            {
                button23.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button24")
            {
                button24.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button25")
            {
                button25.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button26")
            {
                button26.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button27")
            {
                button27.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button28")
            {
                button28.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button29")
            {
                button29.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button30")
            {
                button30.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button31")
            {
                button31.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button32")
            {
                button32.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button33")
            {
                button33.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button34")
            {
                button34.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button35")
            {
                button35.BackColor = Color.Red;
            }
            i++;
            if (Dolukoltuk[i] == "button36")
            {
                button36.BackColor = Color.Red;
            }
            i++;
        }
        public void ligtblueyacevirme()
        {
            int i = 1;
            if (rezervekoltuk[i] == "button1")
            {
                button1.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button2")
            {
                button2.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button3")
            {
                button3.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button4")
            {
                button4.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button5")
            {
                button5.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button6")
            {
                button6.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button7")
            {
                button7.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button8")
            {
                button8.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button9")
            {
                button9.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button10")
            {
                button10.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button11")
            {
                button11.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button12")
            {
                button12.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button13")
            {
                button13.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button14")
            {
                button14.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button15")
            {
                button15.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button16")
            {
                button16.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button17")
            {
                button17.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button18")
            {
                button18.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button19")
            {
                button19.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button20")
            {
                button20.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button21")
            {
                button21.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button22")
            {
                button22.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button23")
            {
                button23.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button24")
            {
                button24.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button25")
            {
                button25.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button26")
            {
                button26.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button27")
            {
                button27.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button28")
            {
                button28.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button29")
            {
                button29.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button30")
            {
                button30.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button31")
            {
                button31.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button32")
            {
                button32.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button33")
            {
                button33.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button34")
            {
                button34.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button35")
            {
                button35.BackColor = Color.LightBlue;
            }
            i++;
            if (rezervekoltuk[i] == "button36")
            {
                button36.BackColor = Color.LightBlue;
            }
            i++;
        }
    }
}
