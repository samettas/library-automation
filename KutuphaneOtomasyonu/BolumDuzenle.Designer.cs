
namespace KutuphaneOtomasyonu
{
    partial class BolumDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BolumDuzenle));
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.btnBolumGuncelle = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.txtBolumID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet6 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet6();
            this.bolumTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet6TableAdapters.BolumTableAdapter();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnBolumListele = new System.Windows.Forms.Button();
            this.txtBolumEkleAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAdi.Location = new System.Drawing.Point(144, 138);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(190, 28);
            this.txtBolumAdi.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Bölüm ID:";
            // 
            // btnBolumSil
            // 
            this.btnBolumSil.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumSil.Location = new System.Drawing.Point(29, 203);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(147, 31);
            this.btnBolumSil.TabIndex = 48;
            this.btnBolumSil.Text = "Sil";
            this.btnBolumSil.UseVisualStyleBackColor = true;
            this.btnBolumSil.Click += new System.EventHandler(this.btnBolumSil_Click);
            // 
            // btnBolumGuncelle
            // 
            this.btnBolumGuncelle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumGuncelle.Location = new System.Drawing.Point(189, 203);
            this.btnBolumGuncelle.Name = "btnBolumGuncelle";
            this.btnBolumGuncelle.Size = new System.Drawing.Size(147, 31);
            this.btnBolumGuncelle.TabIndex = 47;
            this.btnBolumGuncelle.Text = "Güncelle";
            this.btnBolumGuncelle.UseVisualStyleBackColor = true;
            this.btnBolumGuncelle.Click += new System.EventHandler(this.btnBolumGuncelle_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumEkle.Location = new System.Drawing.Point(161, 335);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(147, 31);
            this.btnBolumEkle.TabIndex = 46;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // txtBolumID
            // 
            this.txtBolumID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumID.Location = new System.Drawing.Point(144, 79);
            this.txtBolumID.Name = "txtBolumID";
            this.txtBolumID.Size = new System.Drawing.Size(190, 28);
            this.txtBolumID.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Bölüm Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(351, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(424, 426);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bolumIDDataGridViewTextBoxColumn
            // 
            this.bolumIDDataGridViewTextBoxColumn.DataPropertyName = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.HeaderText = "BolumID";
            this.bolumIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumIDDataGridViewTextBoxColumn.Name = "bolumIDDataGridViewTextBoxColumn";
            this.bolumIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.dB_KUTUPHANEDataSet6;
            // 
            // dB_KUTUPHANEDataSet6
            // 
            this.dB_KUTUPHANEDataSet6.DataSetName = "DB_KUTUPHANEDataSet6";
            this.dB_KUTUPHANEDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 31);
            this.btnGeri.TabIndex = 52;
            this.btnGeri.Text = "◄Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnBolumListele
            // 
            this.btnBolumListele.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumListele.Location = new System.Drawing.Point(189, 12);
            this.btnBolumListele.Name = "btnBolumListele";
            this.btnBolumListele.Size = new System.Drawing.Size(147, 31);
            this.btnBolumListele.TabIndex = 63;
            this.btnBolumListele.Text = "Listele";
            this.btnBolumListele.UseVisualStyleBackColor = true;
            this.btnBolumListele.Click += new System.EventHandler(this.btnBolumListele_Click);
            // 
            // txtBolumEkleAd
            // 
            this.txtBolumEkleAd.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumEkleAd.Location = new System.Drawing.Point(143, 288);
            this.txtBolumEkleAd.Name = "txtBolumEkleAd";
            this.txtBolumEkleAd.Size = new System.Drawing.Size(190, 28);
            this.txtBolumEkleAd.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Bölüm Adı:";
            // 
            // BolumDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBolumEkleAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBolumListele);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBolumSil);
            this.Controls.Add(this.btnBolumGuncelle);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.txtBolumID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BolumDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölüm Düzenle";
            this.Load += new System.EventHandler(this.BolumDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Button btnBolumGuncelle;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.TextBox txtBolumID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_KUTUPHANEDataSet6 dB_KUTUPHANEDataSet6;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private DB_KUTUPHANEDataSet6TableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnBolumListele;
        private System.Windows.Forms.TextBox txtBolumEkleAd;
        private System.Windows.Forms.Label label2;
    }
}