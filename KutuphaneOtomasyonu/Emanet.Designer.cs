
namespace KutuphaneOtomasyonu
{
    partial class Emanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanet));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet11 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet11();
            this.txtEmanetKitapID = new System.Windows.Forms.TextBox();
            this.txtEmanetOgrenciNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmanetID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.emanetTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet11TableAdapters.EmanetTableAdapter();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(-1, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 31);
            this.btnGeri.TabIndex = 50;
            this.btnGeri.Text = "◄Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetVer.Location = new System.Drawing.Point(157, 197);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(190, 31);
            this.btnEmanetVer.TabIndex = 47;
            this.btnEmanetVer.Text = "Ekle";
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            this.btnEmanetVer.Click += new System.EventHandler(this.btnEmanetVer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emanetIDDataGridViewTextBoxColumn,
            this.alisTarihiDataGridViewTextBoxColumn,
            this.verisTarihiDataGridViewTextBoxColumn,
            this.ogrenciNODataGridViewTextBoxColumn,
            this.kitapIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emanetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(405, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 484);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // emanetIDDataGridViewTextBoxColumn
            // 
            this.emanetIDDataGridViewTextBoxColumn.DataPropertyName = "EmanetID";
            this.emanetIDDataGridViewTextBoxColumn.HeaderText = "EmanetID";
            this.emanetIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emanetIDDataGridViewTextBoxColumn.Name = "emanetIDDataGridViewTextBoxColumn";
            this.emanetIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.emanetIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // alisTarihiDataGridViewTextBoxColumn
            // 
            this.alisTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.HeaderText = "AlisTarihi";
            this.alisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alisTarihiDataGridViewTextBoxColumn.Name = "alisTarihiDataGridViewTextBoxColumn";
            this.alisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // verisTarihiDataGridViewTextBoxColumn
            // 
            this.verisTarihiDataGridViewTextBoxColumn.DataPropertyName = "VerisTarihi";
            this.verisTarihiDataGridViewTextBoxColumn.HeaderText = "VerisTarihi";
            this.verisTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.verisTarihiDataGridViewTextBoxColumn.Name = "verisTarihiDataGridViewTextBoxColumn";
            this.verisTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciNODataGridViewTextBoxColumn
            // 
            this.ogrenciNODataGridViewTextBoxColumn.DataPropertyName = "OgrenciNO";
            this.ogrenciNODataGridViewTextBoxColumn.HeaderText = "OgrenciNO";
            this.ogrenciNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNODataGridViewTextBoxColumn.Name = "ogrenciNODataGridViewTextBoxColumn";
            this.ogrenciNODataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // emanetBindingSource
            // 
            this.emanetBindingSource.DataMember = "Emanet";
            this.emanetBindingSource.DataSource = this.dB_KUTUPHANEDataSet11;
            // 
            // dB_KUTUPHANEDataSet11
            // 
            this.dB_KUTUPHANEDataSet11.DataSetName = "DB_KUTUPHANEDataSet11";
            this.dB_KUTUPHANEDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmanetKitapID
            // 
            this.txtEmanetKitapID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmanetKitapID.Location = new System.Drawing.Point(157, 132);
            this.txtEmanetKitapID.Name = "txtEmanetKitapID";
            this.txtEmanetKitapID.Size = new System.Drawing.Size(190, 28);
            this.txtEmanetKitapID.TabIndex = 42;
            this.txtEmanetKitapID.TextChanged += new System.EventHandler(this.txtEmanetKitapID_TextChanged);
            // 
            // txtEmanetOgrenciNo
            // 
            this.txtEmanetOgrenciNo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmanetOgrenciNo.Location = new System.Drawing.Point(157, 82);
            this.txtEmanetOgrenciNo.Name = "txtEmanetOgrenciNo";
            this.txtEmanetOgrenciNo.Size = new System.Drawing.Size(190, 28);
            this.txtEmanetOgrenciNo.TabIndex = 41;
            this.txtEmanetOgrenciNo.TextChanged += new System.EventHandler(this.txtEmanetOgrenciNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kitap ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Öğrenci No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmanetID
            // 
            this.txtEmanetID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmanetID.Location = new System.Drawing.Point(157, 300);
            this.txtEmanetID.Name = "txtEmanetID";
            this.txtEmanetID.Size = new System.Drawing.Size(190, 28);
            this.txtEmanetID.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Emanet ID:";
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEt.Location = new System.Drawing.Point(157, 373);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(190, 31);
            this.btnTeslimEt.TabIndex = 53;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // emanetTableAdapter
            // 
            this.emanetTableAdapter.ClearBeforeFill = true;
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetListele.Location = new System.Drawing.Point(232, 12);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(147, 31);
            this.btnEmanetListele.TabIndex = 54;
            this.btnEmanetListele.Text = "Listele";
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // Emanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 516);
            this.Controls.Add(this.btnEmanetListele);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.txtEmanetID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnEmanetVer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmanetKitapID);
            this.Controls.Add(this.txtEmanetOgrenciNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet";
            this.Load += new System.EventHandler(this.Emanet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnEmanetVer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmanetKitapID;
        private System.Windows.Forms.TextBox txtEmanetOgrenciNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmanetID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTeslimEt;
        private DB_KUTUPHANEDataSet11 dB_KUTUPHANEDataSet11;
        private System.Windows.Forms.BindingSource emanetBindingSource;
        private DB_KUTUPHANEDataSet11TableAdapters.EmanetTableAdapter emanetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emanetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEmanetListele;
    }
}