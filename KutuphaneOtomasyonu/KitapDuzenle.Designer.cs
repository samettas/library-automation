
namespace KutuphaneOtomasyonu
{
    partial class KitapDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayimTarihi = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.kitapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet13 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet13();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet2 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet2();
            this.kitapTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet2TableAdapters.KitapTableAdapter();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtKitapDuzenleID = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.Label();
            this.kitapTableAdapter1 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet13TableAdapters.KitapTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet14 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet14();
            this.kitapTableAdapter2 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet14TableAdapters.KitapTableAdapter();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yayım Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Yazarı ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap YayınEvi ID:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAdi.Location = new System.Drawing.Point(157, 154);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(190, 28);
            this.txtKitapAdi.TabIndex = 8;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfaSayisi.Location = new System.Drawing.Point(157, 204);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(190, 28);
            this.txtSayfaSayisi.TabIndex = 9;
            // 
            // txtYayimTarihi
            // 
            this.txtYayimTarihi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayimTarihi.Location = new System.Drawing.Point(157, 254);
            this.txtYayimTarihi.Name = "txtYayimTarihi";
            this.txtYayimTarihi.Size = new System.Drawing.Size(190, 28);
            this.txtYayimTarihi.TabIndex = 10;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazari.Location = new System.Drawing.Point(157, 304);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(190, 28);
            this.txtKitapYazari.TabIndex = 11;
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvi.Location = new System.Drawing.Point(157, 354);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(190, 28);
            this.txtYayinEvi.TabIndex = 12;
            // 
            // kitapBindingSource1
            // 
            this.kitapBindingSource1.DataMember = "Kitap";
            this.kitapBindingSource1.DataSource = this.dB_KUTUPHANEDataSet13;
            // 
            // dB_KUTUPHANEDataSet13
            // 
            this.dB_KUTUPHANEDataSet13.DataSetName = "DB_KUTUPHANEDataSet13";
            this.dB_KUTUPHANEDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "Kitap";
            this.kitapBindingSource.DataSource = this.dB_KUTUPHANEDataSet2;
            // 
            // dB_KUTUPHANEDataSet2
            // 
            this.dB_KUTUPHANEDataSet2.DataSetName = "DB_KUTUPHANEDataSet2";
            this.dB_KUTUPHANEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGuncelle.Location = new System.Drawing.Point(200, 413);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(147, 31);
            this.btnKitapGuncelle.TabIndex = 15;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapSil.Location = new System.Drawing.Point(30, 472);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(317, 31);
            this.btnKitapSil.TabIndex = 16;
            this.btnKitapSil.Text = "Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 31);
            this.btnGeri.TabIndex = 33;
            this.btnGeri.Text = "◄Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtKitapDuzenleID
            // 
            this.txtKitapDuzenleID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapDuzenleID.Location = new System.Drawing.Point(157, 105);
            this.txtKitapDuzenleID.Name = "txtKitapDuzenleID";
            this.txtKitapDuzenleID.Size = new System.Drawing.Size(190, 28);
            this.txtKitapDuzenleID.TabIndex = 35;
            // 
            // txtKitapID
            // 
            this.txtKitapID.AutoSize = true;
            this.txtKitapID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapID.Location = new System.Drawing.Point(59, 105);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(82, 24);
            this.txtKitapID.TabIndex = 34;
            this.txtKitapID.Text = "Kitap ID:";
            // 
            // kitapTableAdapter1
            // 
            this.kitapTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapIDDataGridViewTextBoxColumn,
            this.kitapAdDataGridViewTextBoxColumn,
            this.sayfaSayisiDataGridViewTextBoxColumn,
            this.yayimTarihiDataGridViewTextBoxColumn,
            this.yazarIDDataGridViewTextBoxColumn,
            this.yayınEviIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitapBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(383, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(937, 457);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdDataGridViewTextBoxColumn
            // 
            this.kitapAdDataGridViewTextBoxColumn.DataPropertyName = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.HeaderText = "KitapAd";
            this.kitapAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdDataGridViewTextBoxColumn.Name = "kitapAdDataGridViewTextBoxColumn";
            this.kitapAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // sayfaSayisiDataGridViewTextBoxColumn
            // 
            this.sayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "SayfaSayisi";
            this.sayfaSayisiDataGridViewTextBoxColumn.HeaderText = "SayfaSayisi";
            this.sayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sayfaSayisiDataGridViewTextBoxColumn.Name = "sayfaSayisiDataGridViewTextBoxColumn";
            this.sayfaSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayimTarihiDataGridViewTextBoxColumn
            // 
            this.yayimTarihiDataGridViewTextBoxColumn.DataPropertyName = "YayimTarihi";
            this.yayimTarihiDataGridViewTextBoxColumn.HeaderText = "YayimTarihi";
            this.yayimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayimTarihiDataGridViewTextBoxColumn.Name = "yayimTarihiDataGridViewTextBoxColumn";
            this.yayimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // yazarIDDataGridViewTextBoxColumn
            // 
            this.yazarIDDataGridViewTextBoxColumn.DataPropertyName = "YazarID";
            this.yazarIDDataGridViewTextBoxColumn.HeaderText = "YazarID";
            this.yazarIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yazarIDDataGridViewTextBoxColumn.Name = "yazarIDDataGridViewTextBoxColumn";
            this.yazarIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // yayınEviIDDataGridViewTextBoxColumn
            // 
            this.yayınEviIDDataGridViewTextBoxColumn.DataPropertyName = "YayınEviID";
            this.yayınEviIDDataGridViewTextBoxColumn.HeaderText = "YayınEviID";
            this.yayınEviIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yayınEviIDDataGridViewTextBoxColumn.Name = "yayınEviIDDataGridViewTextBoxColumn";
            this.yayınEviIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBindingSource2
            // 
            this.kitapBindingSource2.DataMember = "Kitap";
            this.kitapBindingSource2.DataSource = this.dB_KUTUPHANEDataSet14;
            // 
            // dB_KUTUPHANEDataSet14
            // 
            this.dB_KUTUPHANEDataSet14.DataSetName = "DB_KUTUPHANEDataSet14";
            this.dB_KUTUPHANEDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapTableAdapter2
            // 
            this.kitapTableAdapter2.ClearBeforeFill = true;
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListele.Location = new System.Drawing.Point(229, 8);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(147, 31);
            this.btnKitapListele.TabIndex = 37;
            this.btnKitapListele.Text = "Listele";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            this.btnKitapListele.Click += new System.EventHandler(this.btnKitapListele_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Location = new System.Drawing.Point(31, 413);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(147, 31);
            this.btnKitapEkle.TabIndex = 38;
            this.btnKitapEkle.Text = "Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(229, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(147, 31);
            this.btnAra.TabIndex = 39;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // KitapDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 527);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnKitapListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtKitapDuzenleID);
            this.Controls.Add(this.txtKitapID);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKitapSil);
            this.Controls.Add(this.btnKitapGuncelle);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.txtKitapYazari);
            this.Controls.Add(this.txtYayimTarihi);
            this.Controls.Add(this.txtSayfaSayisi);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitapDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapDuzenle";
            this.Load += new System.EventHandler(this.KitapDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayimTarihi;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private DB_KUTUPHANEDataSet2 dB_KUTUPHANEDataSet2;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private DB_KUTUPHANEDataSet2TableAdapters.KitapTableAdapter kitapTableAdapter;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtKitapDuzenleID;
        private System.Windows.Forms.Label txtKitapID;
        private DB_KUTUPHANEDataSet13 dB_KUTUPHANEDataSet13;
        private System.Windows.Forms.BindingSource kitapBindingSource1;
        private DB_KUTUPHANEDataSet13TableAdapters.KitapTableAdapter kitapTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_KUTUPHANEDataSet14 dB_KUTUPHANEDataSet14;
        private System.Windows.Forms.BindingSource kitapBindingSource2;
        private DB_KUTUPHANEDataSet14TableAdapters.KitapTableAdapter kitapTableAdapter2;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviIDDataGridViewTextBoxColumn;
    }
}