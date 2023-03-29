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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Personel where PersonelID=@p1 and PersonelAd=@p2 and BirimID=8", baglanti);
            komut.Parameters.AddWithValue("@p2", txtDanismanAd.Text);
            komut.Parameters.AddWithValue("@p1", txtDanismanSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                DanismaGiris frm = new DanismaGiris();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre !");
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Personel where PersonelID=@p1 and PersonelAd=@p2 and BirimID=9", baglanti);
            komut.Parameters.AddWithValue("@p2", txtYetkiliAd.Text);
            komut.Parameters.AddWithValue("@p1", txtYetkiliSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                YetkiliGiris frm = new YetkiliGiris();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre !");
            }
            baglanti.Close();
        }

        private void txtYetkiliSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
