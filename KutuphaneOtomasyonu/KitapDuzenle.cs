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
    public partial class KitapDuzenle : Form
    {
        public KitapDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void KitapDuzenle_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Kitap Set KitapAd=@a1,SayfaSayisi=@a2,YayimTarihi=@a3,YazarID=@a4,YayınEviID=@a5 where KitapID=@a6", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtKitapAdi.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSayfaSayisi.Text);
            komutguncelle.Parameters.AddWithValue("@a3", txtYayimTarihi.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtKitapYazari.Text);
            komutguncelle.Parameters.AddWithValue("@a5", txtYayinEvi.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtKitapDuzenleID.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Bilgileri Güncellendi !");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YetkiliGiris form1 = new YetkiliGiris();
            this.Hide();
            form1.Show();
        }

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   

            
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtKitapDuzenleID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSayfaSayisi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtYayimTarihi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKitapYazari.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtYayinEvi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet14.Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTableAdapter2.Fill(this.dB_KUTUPHANEDataSet14.Kitap);
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet13.Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTableAdapter1.Fill(this.dB_KUTUPHANEDataSet13.Kitap);
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet2.Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitapTableAdapter.Fill(this.dB_KUTUPHANEDataSet2.Kitap);
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap (KitapAd,SayfaSayisi,YayimTarihi,YazarID,YayınEviID) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@p3", txtYayimTarihi.Text);
            komut.Parameters.AddWithValue("@p4", txtKitapYazari.Text);
            komut.Parameters.AddWithValue("@p5", txtYayinEvi.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi !");
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Kitap where KitapID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtKitapDuzenleID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi !");
            
        }

        private void btnAra_Click(object sender, EventArgs e)

        {   SqlCommand komut1 = new SqlCommand();
            SqlDataReader oku2;
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.Parameters.AddWithValue("@a1", txtKitapDuzenleID.Text);
            komut1.CommandText = "exec sp_Kitap @a1";
            oku2 = komut1.ExecuteReader();
            oku2.Read();
            txtKitapDuzenleID.Text = oku2[0].ToString();
            txtKitapAdi.Text= oku2[1].ToString();
            txtSayfaSayisi.Text= oku2[2].ToString();
            txtYayimTarihi.Text= oku2[3].ToString();
            txtKitapYazari.Text= oku2[4].ToString();
            txtYayinEvi.Text= oku2[5].ToString();
            baglanti.Close();

            
        }
    }
}
