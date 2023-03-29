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
    public partial class YayinEviDuzenle : Form
    {
        public YayinEviDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        private void YayinEviDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet10.YayinEvi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

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

            txtYayinEviID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtYayinEviAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
            
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYayinEviListele_Click(object sender, EventArgs e)
        {
            this.yayinEviTableAdapter.Fill(this.dB_KUTUPHANEDataSet10.YayinEvi);
        }

        private void btnYayinEviGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update YayinEvi Set YayınEviAd=@a2 where YayınEviID=@a1", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtYayinEviID.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtYayinEviAdi.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YayınEvi Bilgileri Güncellendi !");
        }

        private void btnYayinEviEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into YayinEvi (YayınEviAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtYayinEviEkleAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YayınEvi Eklendi !");
        }

        private void btnYayinEviSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete YayinEvi where YayınEviID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtYayinEviID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YayınEvi Silindi !");
        }
    }
}
