using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class YetkiliGiris : Form
    {
        public YetkiliGiris()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KitapDuzenle bolum = new KitapDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnYayinEviDuzenle_Click(object sender, EventArgs e)
        {
            YayinEviDuzenle bolum = new YayinEviDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnYazarDuzenle_Click(object sender, EventArgs e)
        {
            YazarDuzenle bolum = new YazarDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            KategoriDuzenle bolum = new KategoriDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnBolumDuzenle_Click(object sender, EventArgs e)
        {
            BolumDuzenle bolum = new BolumDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnBirimDuzenle_Click(object sender, EventArgs e)
        {
            BirimDuzenle bolum = new BirimDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnOgrenciDuzenle_Click(object sender, EventArgs e)
        {
            OgrenciDuzenle bolum = new OgrenciDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            PersonelDuzenle bolum = new PersonelDuzenle();
            this.Hide();
            bolum.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            AnaForm bolum = new AnaForm();
            this.Hide();
            bolum.Show();
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            IstatistikForm bolum = new IstatistikForm();
            this.Hide();
            bolum.Show();
        }
    }
}
