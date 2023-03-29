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
    public partial class KategoriDuzenle : Form
    {
        public KategoriDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");

        private void KategoriDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet5.Kategori' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

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

            txtKategoriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKategoriAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kategori (KategoriAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKategoriEkleAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Eklendi !");
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Kategori where KategoriID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtKategoriID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Silindi !");
        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            this.kategoriTableAdapter.Fill(this.dB_KUTUPHANEDataSet5.Kategori);
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Kategori Set KategoriAd=@a2 where KategoriID=@a1", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtKategoriID.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtKategoriAdi.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Bilgileri Güncellendi !");
        }
    }
}
