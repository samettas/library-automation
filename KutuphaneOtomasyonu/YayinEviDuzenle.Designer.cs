
namespace KutuphaneOtomasyonu
{
    partial class YayinEviDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YayinEviDuzenle));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnYayinEviSil = new System.Windows.Forms.Button();
            this.btnYayinEviGuncelle = new System.Windows.Forms.Button();
            this.txtYayinEviAdi = new System.Windows.Forms.TextBox();
            this.txtYayinEviID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yayınEviIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınEviAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinEviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet10 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet10();
            this.yayinEviTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet10TableAdapters.YayinEviTableAdapter();
            this.btnYayinEviListele = new System.Windows.Forms.Button();
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.txtYayinEviEkleAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinEviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            resources.ApplyResources(this.btnGeri, "btnGeri");
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnYayinEviSil
            // 
            resources.ApplyResources(this.btnYayinEviSil, "btnYayinEviSil");
            this.btnYayinEviSil.Name = "btnYayinEviSil";
            this.btnYayinEviSil.UseVisualStyleBackColor = true;
            this.btnYayinEviSil.Click += new System.EventHandler(this.btnYayinEviSil_Click);
            // 
            // btnYayinEviGuncelle
            // 
            resources.ApplyResources(this.btnYayinEviGuncelle, "btnYayinEviGuncelle");
            this.btnYayinEviGuncelle.Name = "btnYayinEviGuncelle";
            this.btnYayinEviGuncelle.UseVisualStyleBackColor = true;
            this.btnYayinEviGuncelle.Click += new System.EventHandler(this.btnYayinEviGuncelle_Click);
            // 
            // txtYayinEviAdi
            // 
            resources.ApplyResources(this.txtYayinEviAdi, "txtYayinEviAdi");
            this.txtYayinEviAdi.Name = "txtYayinEviAdi";
            // 
            // txtYayinEviID
            // 
            resources.ApplyResources(this.txtYayinEviID, "txtYayinEviID");
            this.txtYayinEviID.Name = "txtYayinEviID";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yayınEviIDDataGridViewTextBoxColumn,
            this.yayınEviAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yayinEviBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // yayınEviIDDataGridViewTextBoxColumn
            // 
            this.yayınEviIDDataGridViewTextBoxColumn.DataPropertyName = "YayınEviID";
            resources.ApplyResources(this.yayınEviIDDataGridViewTextBoxColumn, "yayınEviIDDataGridViewTextBoxColumn");
            this.yayınEviIDDataGridViewTextBoxColumn.Name = "yayınEviIDDataGridViewTextBoxColumn";
            this.yayınEviIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yayınEviAdDataGridViewTextBoxColumn
            // 
            this.yayınEviAdDataGridViewTextBoxColumn.DataPropertyName = "YayınEviAd";
            resources.ApplyResources(this.yayınEviAdDataGridViewTextBoxColumn, "yayınEviAdDataGridViewTextBoxColumn");
            this.yayınEviAdDataGridViewTextBoxColumn.Name = "yayınEviAdDataGridViewTextBoxColumn";
            // 
            // yayinEviBindingSource
            // 
            this.yayinEviBindingSource.DataMember = "YayinEvi";
            this.yayinEviBindingSource.DataSource = this.dB_KUTUPHANEDataSet10;
            // 
            // dB_KUTUPHANEDataSet10
            // 
            this.dB_KUTUPHANEDataSet10.DataSetName = "DB_KUTUPHANEDataSet10";
            this.dB_KUTUPHANEDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yayinEviTableAdapter
            // 
            this.yayinEviTableAdapter.ClearBeforeFill = true;
            // 
            // btnYayinEviListele
            // 
            resources.ApplyResources(this.btnYayinEviListele, "btnYayinEviListele");
            this.btnYayinEviListele.Name = "btnYayinEviListele";
            this.btnYayinEviListele.UseVisualStyleBackColor = true;
            this.btnYayinEviListele.Click += new System.EventHandler(this.btnYayinEviListele_Click);
            // 
            // btnYayinEviEkle
            // 
            resources.ApplyResources(this.btnYayinEviEkle, "btnYayinEviEkle");
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // txtYayinEviEkleAd
            // 
            resources.ApplyResources(this.txtYayinEviEkleAd, "txtYayinEviEkleAd");
            this.txtYayinEviEkleAd.Name = "txtYayinEviEkleAd";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // YayinEviDuzenle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtYayinEviEkleAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnYayinEviEkle);
            this.Controls.Add(this.btnYayinEviListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYayinEviSil);
            this.Controls.Add(this.btnYayinEviGuncelle);
            this.Controls.Add(this.txtYayinEviAdi);
            this.Controls.Add(this.txtYayinEviID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YayinEviDuzenle";
            this.Load += new System.EventHandler(this.YayinEviDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinEviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnYayinEviSil;
        private System.Windows.Forms.Button btnYayinEviGuncelle;
        private System.Windows.Forms.TextBox txtYayinEviAdi;
        private System.Windows.Forms.TextBox txtYayinEviID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_KUTUPHANEDataSet10 dB_KUTUPHANEDataSet10;
        private System.Windows.Forms.BindingSource yayinEviBindingSource;
        private DB_KUTUPHANEDataSet10TableAdapters.YayinEviTableAdapter yayinEviTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınEviAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnYayinEviListele;
        private System.Windows.Forms.Button btnYayinEviEkle;
        private System.Windows.Forms.TextBox txtYayinEviEkleAd;
        private System.Windows.Forms.Label label3;
    }
}