using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class DanismaGiris : Form
    {
        public DanismaGiris()
        {
            InitializeComponent();
        }

        private void btnEmanet_Click(object sender, EventArgs e)
        {
            Emanet bolum = new Emanet();
            this.Hide();
            bolum.Show();
        }

        private void btnKiralama_Click(object sender, EventArgs e)
        {
            Kiralama bolum = new Kiralama();
            this.Hide();
            bolum.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            AnaForm bolum = new AnaForm();
            this.Hide();
            bolum.Show();
        }
    }
}
