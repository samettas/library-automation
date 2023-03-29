
namespace KutuphaneOtomasyonu
{
    partial class YazarDuzenle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarDuzenle));
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.txtYazarID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazarSoyadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yazarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet4 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet4();
            this.yazarTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet4TableAdapters.YazarTableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnYazarListele = new System.Windows.Forms.Button();
            this.txtYazarEkleSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYazarEkleAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarSil.Location = new System.Drawing.Point(43, 248);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(147, 31);
            this.btnYazarSil.TabIndex = 28;
            this.btnYazarSil.Text = "Sil";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarGuncelle.Location = new System.Drawing.Point(211, 248);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(147, 31);
            this.btnYazarGuncelle.TabIndex = 27;
            this.btnYazarGuncelle.Text = "Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarEkle.Location = new System.Drawing.Point(183, 475);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(147, 31);
            this.btnYazarEkle.TabIndex = 26;
            this.btnYazarEkle.Text = "Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // txtYazarID
            // 
            this.txtYazarID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarID.Location = new System.Drawing.Point(154, 84);
            this.txtYazarID.Name = "txtYazarID";
            this.txtYazarID.Size = new System.Drawing.Size(204, 28);
            this.txtYazarID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Yazar ID:";
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarAdi.Location = new System.Drawing.Point(154, 137);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(204, 28);
            this.txtYazarAdi.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Yazar Adı:";
            // 
            // txtYazarSoyadi
            // 
            this.txtYazarSoyadi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarSoyadi.Location = new System.Drawing.Point(154, 192);
            this.txtYazarSoyadi.Name = "txtYazarSoyadi";
            this.txtYazarSoyadi.Size = new System.Drawing.Size(204, 28);
            this.txtYazarSoyadi.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Yazar Soyadı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yazarIDDataGridViewTextBoxColumn,
            this.yazarAdDataGridViewTextBoxColumn,
            this.yazarSoyadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yazarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(499, 510);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // yazarIDDataGridViewTextBoxColumn
            // 
            this.yazarIDDataGridViewTextBoxColumn.DataPropertyName = "YazarID";
            this.yazarIDDataGridViewTextBoxColumn.HeaderText = "YazarID";
            this.yazarIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarIDDataGridViewTextBoxColumn.Name = "yazarIDDataGridViewTextBoxColumn";
            this.yazarIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.yazarIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarAdDataGridViewTextBoxColumn
            // 
            this.yazarAdDataGridViewTextBoxColumn.DataPropertyName = "YazarAd";
            this.yazarAdDataGridViewTextBoxColumn.HeaderText = "YazarAd";
            this.yazarAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarAdDataGridViewTextBoxColumn.Name = "yazarAdDataGridViewTextBoxColumn";
            this.yazarAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarSoyadDataGridViewTextBoxColumn
            // 
            this.yazarSoyadDataGridViewTextBoxColumn.DataPropertyName = "YazarSoyad";
            this.yazarSoyadDataGridViewTextBoxColumn.HeaderText = "YazarSoyad";
            this.yazarSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarSoyadDataGridViewTextBoxColumn.Name = "yazarSoyadDataGridViewTextBoxColumn";
            this.yazarSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarBindingSource
            // 
            this.yazarBindingSource.DataMember = "Yazar";
            this.yazarBindingSource.DataSource = this.dB_KUTUPHANEDataSet4;
            // 
            // dB_KUTUPHANEDataSet4
            // 
            this.dB_KUTUPHANEDataSet4.DataSetName = "DB_KUTUPHANEDataSet4";
            this.dB_KUTUPHANEDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarTableAdapter
            // 
            this.yazarTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 31);
            this.btnGeri.TabIndex = 32;
            this.btnGeri.Text = "◄Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYazarListele
            // 
            this.btnYazarListele.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarListele.Location = new System.Drawing.Point(223, 12);
            this.btnYazarListele.Name = "btnYazarListele";
            this.btnYazarListele.Size = new System.Drawing.Size(147, 31);
            this.btnYazarListele.TabIndex = 38;
            this.btnYazarListele.Text = "Listele";
            this.btnYazarListele.UseVisualStyleBackColor = true;
            this.btnYazarListele.Click += new System.EventHandler(this.btnYazarListele_Click);
            // 
            // txtYazarEkleSoyad
            // 
            this.txtYazarEkleSoyad.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarEkleSoyad.Location = new System.Drawing.Point(168, 419);
            this.txtYazarEkleSoyad.Name = "txtYazarEkleSoyad";
            this.txtYazarEkleSoyad.Size = new System.Drawing.Size(190, 28);
            this.txtYazarEkleSoyad.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(27, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 41;
            this.label5.Text = "Yazar Soyadı:";
            // 
            // txtYazarEkleAd
            // 
            this.txtYazarEkleAd.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazarEkleAd.Location = new System.Drawing.Point(168, 364);
            this.txtYazarEkleAd.Name = "txtYazarEkleAd";
            this.txtYazarEkleAd.Size = new System.Drawing.Size(190, 28);
            this.txtYazarEkleAd.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Yazar Adı:";
            // 
            // YazarDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 534);
            this.Controls.Add(this.txtYazarEkleSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazarEkleAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnYazarListele);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYazarSoyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnYazarSil);
            this.Controls.Add(this.btnYazarGuncelle);
            this.Controls.Add(this.btnYazarEkle);
            this.Controls.Add(this.txtYazarID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YazarDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Düzenle";
            this.Load += new System.EventHandler(this.YazarDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.TextBox txtYazarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazarSoyadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_KUTUPHANEDataSet4 dB_KUTUPHANEDataSet4;
        private System.Windows.Forms.BindingSource yazarBindingSource;
        private DB_KUTUPHANEDataSet4TableAdapters.YazarTableAdapter yazarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnYazarListele;
        private System.Windows.Forms.TextBox txtYazarEkleSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYazarEkleAd;
        private System.Windows.Forms.Label label6;
    }
}