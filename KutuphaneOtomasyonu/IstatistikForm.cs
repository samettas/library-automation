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
    public partial class IstatistikForm : Form
    {
        public IstatistikForm()
        {
            InitializeComponent();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-24N88AV\\SQLEXPRESS;Initial Catalog=DB_KUTUPHANE;Integrated Security=True");

            //Toplam Öğrenci Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Ogrenci", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamOgrenci.Text = dr1[0].ToString();
            }

            baglanti.Close();

            //Toplam Erkek Öğrenci Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Ogrenci where Cinsiyet=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblToplamErkek.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Toplam Kız Öğrenci Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Ogrenci where Cinsiyet=2", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblToplamKiz.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Toplam Kitap Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(KitapID)) From Kitap", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblToplamKitap.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Count(*) From Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamPersonel.Text = dr5[0].ToString();
            }
            baglanti.Close();

            //Toplam Kategori Sayısı
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Count(*) From Kategori", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblToplamKategori.Text = dr6[0].ToString();
            }
            baglanti.Close();

            //Toplam Birim Sayısı
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select Count(*) From Birim", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblToplamBirim.Text = dr7[0].ToString();
            }
            baglanti.Close();

            //Toplam Bölüm Sayısı
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select Count(*) From Bolum", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblToplamBolum.Text = dr8[0].ToString();
            }
            baglanti.Close();

            //Toplam Emanet Sayısı
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select Count(*) From Emanet", baglanti);
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblToplamEmanet.Text = dr9[0].ToString();
            }

            baglanti.Close();

            //Toplam Kiralama Sayısı
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("Select Count(*) From Kiralamalar", baglanti);
            SqlDataReader dr10 = komut10.ExecuteReader();
            while (dr10.Read())
            {
                lblToplamKiralama.Text = dr10[0].ToString();
            }

            baglanti.Close();

            //Toplam YayınEvi Sayısı
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("Select Count(*) From YayinEvi", baglanti);
            SqlDataReader dr11 = komut11.ExecuteReader();
            while (dr11.Read())
            {
                lblToplamYayinEvi.Text = dr11[0].ToString();
            }

            baglanti.Close();

            //Toplam Yazar Sayısı
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("Select Count(*) From Yazar", baglanti);
            SqlDataReader dr12 = komut12.ExecuteReader();
            while (dr12.Read())
            {
                lblToplamYazar.Text = dr12[0].ToString();
            }

            baglanti.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            YetkiliGiris form1 = new YetkiliGiris();
            this.Hide();
            form1.Show();
        }
    }
}
