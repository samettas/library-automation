
namespace KutuphaneOtomasyonu
{
    partial class DanismaGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanismaGiris));
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKiralama = new System.Windows.Forms.Button();
            this.btnEmanet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnCikisYap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCikisYap.Location = new System.Drawing.Point(-1, 0);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(153, 34);
            this.btnCikisYap.TabIndex = 13;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(231, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "DANIŞMA SAYFASI";
            // 
            // btnKiralama
            // 
            this.btnKiralama.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnKiralama.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKiralama.Location = new System.Drawing.Point(440, 138);
            this.btnKiralama.Name = "btnKiralama";
            this.btnKiralama.Size = new System.Drawing.Size(277, 34);
            this.btnKiralama.TabIndex = 11;
            this.btnKiralama.Text = "Kiralama";
            this.btnKiralama.UseVisualStyleBackColor = true;
            this.btnKiralama.Click += new System.EventHandler(this.btnKiralama_Click);
            // 
            // btnEmanet
            // 
            this.btnEmanet.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmanet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEmanet.Location = new System.Drawing.Point(37, 138);
            this.btnEmanet.Name = "btnEmanet";
            this.btnEmanet.Size = new System.Drawing.Size(277, 34);
            this.btnEmanet.TabIndex = 10;
            this.btnEmanet.Text = "Emanet";
            this.btnEmanet.UseVisualStyleBackColor = true;
            this.btnEmanet.Click += new System.EventHandler(this.btnEmanet_Click);
            // 
            // DanismaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKiralama);
            this.Controls.Add(this.btnEmanet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanismaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danışma Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKiralama;
        private System.Windows.Forms.Button btnEmanet;
    }
}