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
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emanet_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet11.Emanet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            DanismaGiris form1 = new DanismaGiris();
            this.Hide();
            form1.Show();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Emanet (OgrenciNO,KitapID,AlisTarihi) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtEmanetOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p2", txtEmanetKitapID.Text);
            komut.Parameters.AddWithValue("@p3", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Eklendi !");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmanetKitapID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmanetOgrenciNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtEmanetOgrenciNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtEmanetKitapID.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Emanet where EmanetID=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtEmanetID.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi !");
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            this.emanetTableAdapter.Fill(this.dB_KUTUPHANEDataSet11.Emanet);
        }
    }
}
