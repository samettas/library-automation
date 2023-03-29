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
    public partial class OgrenciDuzenle : Form
    {
        public OgrenciDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");

        private void OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet8.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

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

            txtOgrenciNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOgrenciAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtOgrenciSoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtOgrenciCinsiyeti.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtOgrenciBolumID.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrenciNO,OgrenciAd,OgrenciSoyad,Cinsiyet,BolumID) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrenciAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtOgrenciSoyadi.Text);
            komut.Parameters.AddWithValue("@p4", txtOgrenciCinsiyeti.Text);
            komut.Parameters.AddWithValue("@p5", txtOgrenciBolumID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Eklendi !");
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Ogrenci Set OgrenciAd=@a2,OgrenciSoyad=@a3,Cinsiyet=@a4,BolumID=@a5 where OgrenciNO=@a1", baglanti);

            komutguncelle.Parameters.AddWithValue("@a1", txtOgrenciNo.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtOgrenciAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtOgrenciSoyadi.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtOgrenciCinsiyeti.Text);
            komutguncelle.Parameters.AddWithValue("@a5", txtOgrenciBolumID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi !");
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Ogrenci where OgrenciNO=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtOgrenciNo.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Silindi !");
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            this.ogrenciTableAdapter.Fill(this.dB_KUTUPHANEDataSet8.Ogrenci);
        }
    }
}
