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

namespace KutuphaneOtomasyonu
{
    public partial class BolumDuzenle : Form
    {
        public BolumDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        private void BolumDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet6.Bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Bolum Set BolumAd=@a2 where BolumID=@a1", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtBolumID.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtBolumAdi.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bölüm Bilgileri Güncellendi !");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YetkiliGiris form1 = new YetkiliGiris();
            this.Hide();
            form1.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtBolumID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBolumAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btnBolumListele_Click(object sender, EventArgs e)
        {
            this.bolumTableAdapter.Fill(this.dB_KUTUPHANEDataSet6.Bolum);
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Bolum (BolumAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBolumEkleAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bölüm Eklendi !");
        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Bolum where BolumID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtBolumID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bölüm Silindi !");
        }
    }
}
