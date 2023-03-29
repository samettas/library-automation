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
    public partial class Kiralama : Form
    {
        public Kiralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlCommand komut1 = new SqlCommand();
        private void Kiralama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dB_KUTUPHANEDataSet12.Kiralamalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            
            cmbKiralamaAdi.Items.Clear();
            SqlDataReader oku1;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from Kiralama_Cesit";
            oku1 = komut.ExecuteReader();
            while (oku1.Read())
            {
                cmbKiralamaAdi.Items.Add(oku1[1].ToString());
            }
            baglanti.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            DanismaGiris form1 = new DanismaGiris();
            this.Hide();
            form1.Show();
        }

        private void cmbKiralamaAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKiralamaAdi.SelectedIndex != -1)
            {
                string secilen = cmbKiralamaAdi.Items[cmbKiralamaAdi.SelectedIndex].ToString();
                label5.Text = secilen;

            }
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kiralamalar (KiralamaAd,PersonelID,OgrenciNO,Saat) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", label5.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelID.Text);
            komut.Parameters.AddWithValue("@p3", txtOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", DateTime.Now.ToString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kiralama Oluşturuldu !");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.kiralamalarTableAdapter.Fill(this.dB_KUTUPHANEDataSet12.Kiralamalar);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            cmbKiralamaAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPersonelID.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtOgrenciNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnKiralamaSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Kiralamalar where KiralamaAd=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", label5.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kiralama Silindi !");
        }

        private void btnGecKirala_Click(object sender, EventArgs e)
        {
            SqlDataReader oku2;
            baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "select * from GecKiralama";
            oku2=komut1.ExecuteReader();
            oku2.Read();
            lblSaat.Text = oku2[0].ToString();
            baglanti.Close();
            label4.Visible = true;
            lblSaat.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
