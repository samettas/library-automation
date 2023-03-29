
namespace KutuphaneOtomasyonu
{
    partial class Kiralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kiralama));
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnKirala = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kiralamalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_KUTUPHANEDataSet12 = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet12();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKiralamaAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kiralamalarTableAdapter = new KutuphaneOtomasyonu.DB_KUTUPHANEDataSet12TableAdapters.KiralamalarTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKiralamaSil = new System.Windows.Forms.Button();
            this.btnGecKirala = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.kiralamaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiralamaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 31);
            this.btnGeri.TabIndex = 59;
            this.btnGeri.Text = "◄Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirala.Location = new System.Drawing.Point(26, 249);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(168, 31);
            this.btnKirala.TabIndex = 58;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kiralamaIDDataGridViewTextBoxColumn,
            this.kiralamaAdDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.ogrenciNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kiralamalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(414, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(786, 386);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kiralamalarBindingSource
            // 
            this.kiralamalarBindingSource.DataMember = "Kiralamalar";
            this.kiralamalarBindingSource.DataSource = this.dB_KUTUPHANEDataSet12;
            // 
            // dB_KUTUPHANEDataSet12
            // 
            this.dB_KUTUPHANEDataSet12.DataSetName = "DB_KUTUPHANEDataSet12";
            this.dB_KUTUPHANEDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciNo.Location = new System.Drawing.Point(140, 197);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(239, 28);
            this.txtOgrenciNo.TabIndex = 56;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(140, 147);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(239, 28);
            this.txtPersonelID.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Personel ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Öğrenci No:";
            // 
            // cmbKiralamaAdi
            // 
            this.cmbKiralamaAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKiralamaAdi.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKiralamaAdi.FormattingEnabled = true;
            this.cmbKiralamaAdi.Location = new System.Drawing.Point(140, 89);
            this.cmbKiralamaAdi.Name = "cmbKiralamaAdi";
            this.cmbKiralamaAdi.Size = new System.Drawing.Size(239, 29);
            this.cmbKiralamaAdi.TabIndex = 60;
            this.cmbKiralamaAdi.SelectedIndexChanged += new System.EventHandler(this.cmbKiralamaAdi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Kiralama Adı:";
            // 
            // kiralamalarTableAdapter
            // 
            this.kiralamalarTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Label";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(189, 24);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(190, 31);
            this.btnListele.TabIndex = 63;
            this.btnListele.Text = "Listeyi  Yenile";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKiralamaSil
            // 
            this.btnKiralamaSil.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnKiralamaSil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKiralamaSil.Location = new System.Drawing.Point(210, 249);
            this.btnKiralamaSil.Name = "btnKiralamaSil";
            this.btnKiralamaSil.Size = new System.Drawing.Size(169, 31);
            this.btnKiralamaSil.TabIndex = 64;
            this.btnKiralamaSil.Text = "Sil";
            this.btnKiralamaSil.UseVisualStyleBackColor = true;
            this.btnKiralamaSil.Click += new System.EventHandler(this.btnKiralamaSil_Click);
            // 
            // btnGecKirala
            // 
            this.btnGecKirala.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecKirala.Location = new System.Drawing.Point(26, 322);
            this.btnGecKirala.Name = "btnGecKirala";
            this.btnGecKirala.Size = new System.Drawing.Size(168, 31);
            this.btnGecKirala.TabIndex = 65;
            this.btnGecKirala.Text = "En Geç Kiralama";
            this.btnGecKirala.UseVisualStyleBackColor = true;
            this.btnGecKirala.Click += new System.EventHandler(this.btnGecKirala_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(212, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "Saat:";
            this.label4.Visible = false;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(265, 324);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 24);
            this.lblSaat.TabIndex = 67;
            this.lblSaat.Click += new System.EventHandler(this.label7_Click);
            // 
            // kiralamaIDDataGridViewTextBoxColumn
            // 
            this.kiralamaIDDataGridViewTextBoxColumn.DataPropertyName = "KiralamaID";
            this.kiralamaIDDataGridViewTextBoxColumn.HeaderText = "KiralamaID";
            this.kiralamaIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiralamaIDDataGridViewTextBoxColumn.Name = "kiralamaIDDataGridViewTextBoxColumn";
            this.kiralamaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kiralamaIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kiralamaAdDataGridViewTextBoxColumn
            // 
            this.kiralamaAdDataGridViewTextBoxColumn.DataPropertyName = "KiralamaAd";
            this.kiralamaAdDataGridViewTextBoxColumn.HeaderText = "KiralamaAd";
            this.kiralamaAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kiralamaAdDataGridViewTextBoxColumn.Name = "kiralamaAdDataGridViewTextBoxColumn";
            this.kiralamaAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "Saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "Saat";
            this.saatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            this.saatDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciNODataGridViewTextBoxColumn
            // 
            this.ogrenciNODataGridViewTextBoxColumn.DataPropertyName = "OgrenciNO";
            this.ogrenciNODataGridViewTextBoxColumn.HeaderText = "OgrenciNO";
            this.ogrenciNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciNODataGridViewTextBoxColumn.Name = "ogrenciNODataGridViewTextBoxColumn";
            this.ogrenciNODataGridViewTextBoxColumn.Width = 125;
            // 
            // Kiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 451);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGecKirala);
            this.Controls.Add(this.btnKiralamaSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKiralamaAdi);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralama";
            this.Load += new System.EventHandler(this.Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralamalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_KUTUPHANEDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKiralamaAdi;
        private System.Windows.Forms.Label label3;
        private DB_KUTUPHANEDataSet12 dB_KUTUPHANEDataSet12;
        private System.Windows.Forms.BindingSource kiralamalarBindingSource;
        private DB_KUTUPHANEDataSet12TableAdapters.KiralamalarTableAdapter kiralamalarTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKiralamaSil;
        private System.Windows.Forms.Button btnGecKirala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiralamaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciNODataGridViewTextBoxColumn;
    }
}