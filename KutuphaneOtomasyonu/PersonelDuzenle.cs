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
    public partial class PersonelDuzenle : Form
    {
        public PersonelDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        private void PersonelDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet9.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Personel Set PersonelAd=@a2,PersonelSoyad=@a3,BirimID=@a4 where PersonelID=@a1", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtPersonelID.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtPersonelAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtPersonelSoyadi.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtPersonelBirimID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Bilgileri Güncellendi !");
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

            txtPersonelID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPersonelAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPersonelSoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPersonelBirimID.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAd,PersonelSoyad,BirimID) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtPersonelAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelSoyadi.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonelBirimID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi !");
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.dB_KUTUPHANEDataSet9.Personel);
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Personel where PersonelID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtPersonelID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi !");
        }
    }
}
