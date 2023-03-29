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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            progressBar1.BackColor = Color.FromArgb(44, 66, 99);
            progressBar1.ForeColor = Color.FromArgb(44, 66, 75);
            progressBar1.Value = 1;
            progressBar1.Step = 10;
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int ticks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks=ticks+4;
            progressBar1.Value = ticks;
            lblYuzde.Text = progressBar1.Value.ToString();

            if (ticks == 100)
            {
                timer1.Enabled = false;
                ticks = 0;
                AnaForm frm = new AnaForm();
                frm.Show();
                this.Hide();
            }
        }
    }
}
