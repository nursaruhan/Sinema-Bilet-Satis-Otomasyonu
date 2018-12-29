using SinemaBiletSatis.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatis
{
    public partial class adminBiletFormu : Form
    {
        public adminBiletFormu()
        {
            InitializeComponent();
            adminBiletController biletController = new adminBiletController();
            dataGridViewBiletSatis.DataSource = biletController.BiletleriGoster();
            toplamPara();
        }
        public void toplamPara()
        {
            int Topla = 0;
            for (int i = 0; i < dataGridViewBiletSatis.Rows.Count; ++i)
            {
                Topla += Convert.ToInt32(dataGridViewBiletSatis.Rows[i].Cells[6].Value);
            }
            toplamTutar.Text = "Toplam Tutar: " + Convert.ToString(Topla);//çalıştır
        }
        string biletDurumu;
        private void buttonListele_Click(object sender, EventArgs e)
        {
            adminBiletController biletController = new adminBiletController();
            if (radioButtonRezerve.Checked == false || radioButtonSatilan.Checked == false)
            {
                
                dataGridViewBiletSatis.DataSource = biletController.BiletleriGoster();
                toplamPara();
            }
            if (radioButtonRezerve.Checked == true)
            {
                biletDurumu = "rezerve";
                dataGridViewBiletSatis.DataSource = biletController.BiletDurumuBiletleriGoster(biletDurumu);
                toplamPara();
                radioButtonRezerve.Checked = false;
            }
            if (radioButtonSatilan.Checked == true)
            {
                biletDurumu = "satıldı";
                dataGridViewBiletSatis.DataSource = biletController.BiletDurumuBiletleriGoster(biletDurumu);
                toplamPara();
                radioButtonSatilan.Checked = false;
            }
        }

        private void buttonKasayiBosalt_Click(object sender, EventArgs e)
        {
            adminBiletController biletController = new adminBiletController();
            biletController.gecmisKasayiBosalt();
            dataGridViewBiletSatis.DataSource = biletController.BiletleriGoster();
            toplamPara();
        }

        private void buttonGunlukToplam_Click(object sender, EventArgs e)
        {
            adminBiletController biletController = new adminBiletController();
            dataGridViewBiletSatis.DataSource = biletController.BugunSatilanBiletleriGoster();
            toplamPara();
        }

        private void adminBiletFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
