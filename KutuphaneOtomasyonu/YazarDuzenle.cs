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
    public partial class YazarDuzenle : Form
    {
        public YazarDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");

        private void YazarDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet4.Yazar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YetkiliGiris form1 = new YetkiliGiris();
            this.Hide();
            form1.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtYazarID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtYazarAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazarSoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yazar (YazarAd,YazarSoyad) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtYazarEkleAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYazarEkleSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yazar Eklendi !");
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Yazar where YazarID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtYazarID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yazar Silindi !");
        }

        private void btnYazarListele_Click(object sender, EventArgs e)
        {
            this.yazarTableAdapter.Fill(this.dB_KUTUPHANEDataSet4.Yazar);
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Yazar Set YazarAd=@a1,YazarSoyad=@a2 where YazarID=@a3", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtYazarAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtYazarSoyadi.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtYazarID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yazar Bilgileri Güncellendi !");
        }
    }
}
