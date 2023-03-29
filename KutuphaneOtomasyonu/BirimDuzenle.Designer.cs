
namespace KutuphaneOtomasyonu
{
    partial class BirimDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirimDuzenle));
            this.txtBirimAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBirimSil = new System.Windows.Forms.Button();
            this.btnBirimGuncelle = new System.Windows.Forms.Button();
            this.btnBirimEkle = new System.Windows.Forms.Button();
            this.txtBirimID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.birimIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet7 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet7();
            this.birimTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet7TableAdapters.BirimTableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnBirimListele = new System.Windows.Forms.Button();
            this.txtBirimEkleAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirimAdi
            // 
            this.txtBirimAdi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimAdi.Location = new System.Drawing.Point(146, 147);
            this.txtBirimAdi.Name = "txtBirimAdi";
            this.txtBirimAdi.Size = new System.Drawing.Size(190, 28);
            this.txtBirimAdi.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 58;
            this.label4.Text = "Birim ID:";
            // 
            // btnBirimSil
            // 
            this.btnBirimSil.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimSil.Location = new System.Drawing.Point(22, 212);
            this.btnBirimSil.Name = "btnBirimSil";
            this.btnBirimSil.Size = new System.Drawing.Size(149, 31);
            this.btnBirimSil.TabIndex = 57;
            this.btnBirimSil.Text = "Sil";
            this.btnBirimSil.UseVisualStyleBackColor = true;
            this.btnBirimSil.Click += new System.EventHandler(this.btnBirimSil_Click);
            // 
            // btnBirimGuncelle
            // 
            this.btnBirimGuncelle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimGuncelle.Location = new System.Drawing.Point(191, 212);
            this.btnBirimGuncelle.Name = "btnBirimGuncelle";
            this.btnBirimGuncelle.Size = new System.Drawing.Size(149, 31);
            this.btnBirimGuncelle.TabIndex = 56;
            this.btnBirimGuncelle.Text = "Güncelle";
            this.btnBirimGuncelle.UseVisualStyleBackColor = true;
            this.btnBirimGuncelle.Click += new System.EventHandler(this.btnBirimGuncelle_Click);
            // 
            // btnBirimEkle
            // 
            this.btnBirimEkle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimEkle.Location = new System.Drawing.Point(164, 343);
            this.btnBirimEkle.Name = "btnBirimEkle";
            this.btnBirimEkle.Size = new System.Drawing.Size(147, 31);
            this.btnBirimEkle.TabIndex = 55;
            this.btnBirimEkle.Text = "Ekle";
            this.btnBirimEkle.UseVisualStyleBackColor = true;
            this.btnBirimEkle.Click += new System.EventHandler(this.btnBirimEkle_Click);
            // 
            // txtBirimID
            // 
            this.txtBirimID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimID.Location = new System.Drawing.Point(146, 88);
            this.txtBirimID.Name = "txtBirimID";
            this.txtBirimID.Size = new System.Drawing.Size(190, 28);
            this.txtBirimID.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Birim Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.birimIDDataGridViewTextBoxColumn,
            this.birimAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.birimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(346, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 415);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // birimIDDataGridViewTextBoxColumn
            // 
            this.birimIDDataGridViewTextBoxColumn.DataPropertyName = "BirimID";
            this.birimIDDataGridViewTextBoxColumn.HeaderText = "BirimID";
            this.birimIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimIDDataGridViewTextBoxColumn.Name = "birimIDDataGridViewTextBoxColumn";
            this.birimIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.birimIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimAdDataGridViewTextBoxColumn
            // 
            this.birimAdDataGridViewTextBoxColumn.DataPropertyName = "BirimAd";
            this.birimAdDataGridViewTextBoxColumn.HeaderText = "BirimAd";
            this.birimAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimAdDataGridViewTextBoxColumn.Name = "birimAdDataGridViewTextBoxColumn";
            this.birimAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataMember = "Birim";
            this.birimBindingSource.DataSource = this.dB_KUTUPHANEDataSet7;
            // 
            // dB_KUTUPHANEDataSet7
            // 
            this.dB_KUTUPHANEDataSet7.DataSetName = "DB_KUTUPHANEDataSet7";
            this.dB_KUTUPHANEDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birimTableAdapter
            // 
            this.birimTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 31);
            this.btnGeri.TabIndex = 61;
            this.btnGeri.Text = "◄Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnBirimListele
            // 
            this.btnBirimListele.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirimListele.Location = new System.Drawing.Point(191, 23);
            this.btnBirimListele.Name = "btnBirimListele";
            this.btnBirimListele.Size = new System.Drawing.Size(147, 31);
            this.btnBirimListele.TabIndex = 62;
            this.btnBirimListele.Text = "Listele";
            this.btnBirimListele.UseVisualStyleBackColor = true;
            this.btnBirimListele.Click += new System.EventHandler(this.btnBirimListele_Click);
            // 
            // txtBirimEkleAd
            // 
            this.txtBirimEkleAd.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimEkleAd.Location = new System.Drawing.Point(146, 296);
            this.txtBirimEkleAd.Name = "txtBirimEkleAd";
            this.txtBirimEkleAd.Size = new System.Drawing.Size(190, 28);
            this.txtBirimEkleAd.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Birim Adı:";
            // 
            // BirimDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 457);
            this.Controls.Add(this.txtBirimEkleAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBirimListele);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBirimAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBirimSil);
            this.Controls.Add(this.btnBirimGuncelle);
            this.Controls.Add(this.btnBirimEkle);
            this.Controls.Add(this.txtBirimID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BirimDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birim Düzenle";
            this.Load += new System.EventHandler(this.BirimDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirimAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBirimSil;
        private System.Windows.Forms.Button btnBirimGuncelle;
        private System.Windows.Forms.Button btnBirimEkle;
        private System.Windows.Forms.TextBox txtBirimID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_KUTUPHANEDataSet7 dB_KUTUPHANEDataSet7;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private DB_KUTUPHANEDataSet7TableAdapters.BirimTableAdapter birimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnBirimListele;
        private System.Windows.Forms.TextBox txtBirimEkleAd;
        private System.Windows.Forms.Label label2;
    }
}