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
    public partial class BirimDuzenle : Form
    {
        public BirimDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        private void BirimDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet7.Birim' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

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

            txtBirimID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBirimAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnBirimEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Birim (BirimAd) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtBirimEkleAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Birim Eklendi !");
        }

        private void btnBirimGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Birim Set BirimAd=@a2 where BirimID=@a1", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtBirimID.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtBirimAdi.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Birim Bilgileri Güncellendi !");
        }

        private void btnBirimSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete Birim where BirimID=@a1", baglanti);
            komutsil.Parameters.AddWithValue("@a1", txtBirimID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Birim Silindi !");
        }

        private void btnBirimListele_Click(object sender, EventArgs e)
        {
            this.birimTableAdapter.Fill(this.dB_KUTUPHANEDataSet7.Birim);
        }
    }
}
