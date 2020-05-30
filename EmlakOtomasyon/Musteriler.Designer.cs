namespace EmlakOtomasyon
{
    partial class Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.btn_mus_ekle = new System.Windows.Forms.Button();
            this.dgv_ekle = new System.Windows.Forms.DataGridView();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet2 = new EmlakOtomasyon.emlakDataSet2();
            this.btn_mus_duzenle = new System.Windows.Forms.Button();
            this.musterilerTableAdapter = new EmlakOtomasyon.emlakDataSet2TableAdapters.MusterilerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ekle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri AD :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri SOYAD :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail Adresi :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ad.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.ForeColor = System.Drawing.Color.White;
            this.txt_ad.Location = new System.Drawing.Point(136, 64);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(110, 21);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_soyad.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.ForeColor = System.Drawing.Color.White;
            this.txt_soyad.Location = new System.Drawing.Point(136, 112);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(110, 21);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_telefon
            // 
            this.txt_telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_telefon.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.ForeColor = System.Drawing.Color.White;
            this.txt_telefon.Location = new System.Drawing.Point(136, 152);
            this.txt_telefon.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(110, 21);
            this.txt_telefon.TabIndex = 1;
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.ForeColor = System.Drawing.Color.White;
            this.txt_mail.Location = new System.Drawing.Point(136, 197);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(110, 21);
            this.txt_mail.TabIndex = 1;
            // 
            // btn_mus_ekle
            // 
            this.btn_mus_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_mus_ekle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mus_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_mus_ekle.Location = new System.Drawing.Point(11, 243);
            this.btn_mus_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mus_ekle.Name = "btn_mus_ekle";
            this.btn_mus_ekle.Size = new System.Drawing.Size(233, 30);
            this.btn_mus_ekle.TabIndex = 18;
            this.btn_mus_ekle.Text = "Müşteri Ekle";
            this.btn_mus_ekle.UseVisualStyleBackColor = false;
            this.btn_mus_ekle.Click += new System.EventHandler(this.btn_mus_ekle_Click);
            // 
            // dgv_ekle
            // 
            this.dgv_ekle.AutoGenerateColumns = false;
            this.dgv_ekle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_ekle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ekle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musteriSoyadDataGridViewTextBoxColumn,
            this.musteriTelDataGridViewTextBoxColumn,
            this.musteriMailDataGridViewTextBoxColumn});
            this.dgv_ekle.DataSource = this.musterilerBindingSource;
            this.dgv_ekle.Location = new System.Drawing.Point(255, 64);
            this.dgv_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ekle.Name = "dgv_ekle";
            this.dgv_ekle.RowTemplate.Height = 24;
            this.dgv_ekle.Size = new System.Drawing.Size(544, 209);
            this.dgv_ekle.TabIndex = 19;
            this.dgv_ekle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ekle_CellDoubleClick);
            // 
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Id";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "Müşteri No";
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Ad";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "AD";
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            // 
            // musteriSoyadDataGridViewTextBoxColumn
            // 
            this.musteriSoyadDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Soyad";
            this.musteriSoyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.musteriSoyadDataGridViewTextBoxColumn.Name = "musteriSoyadDataGridViewTextBoxColumn";
            // 
            // musteriTelDataGridViewTextBoxColumn
            // 
            this.musteriTelDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Tel";
            this.musteriTelDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.musteriTelDataGridViewTextBoxColumn.Name = "musteriTelDataGridViewTextBoxColumn";
            // 
            // musteriMailDataGridViewTextBoxColumn
            // 
            this.musteriMailDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Mail";
            this.musteriMailDataGridViewTextBoxColumn.HeaderText = "E-MAİL";
            this.musteriMailDataGridViewTextBoxColumn.Name = "musteriMailDataGridViewTextBoxColumn";
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.emlakDataSet2;
            // 
            // emlakDataSet2
            // 
            this.emlakDataSet2.DataSetName = "emlakDataSet2";
            this.emlakDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_mus_duzenle
            // 
            this.btn_mus_duzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_mus_duzenle.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mus_duzenle.ForeColor = System.Drawing.Color.White;
            this.btn_mus_duzenle.Location = new System.Drawing.Point(11, 345);
            this.btn_mus_duzenle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mus_duzenle.Name = "btn_mus_duzenle";
            this.btn_mus_duzenle.Size = new System.Drawing.Size(233, 30);
            this.btn_mus_duzenle.TabIndex = 20;
            this.btn_mus_duzenle.Text = "Müşteri Düzenle";
            this.btn_mus_duzenle.UseVisualStyleBackColor = false;
            this.btn_mus_duzenle.Click += new System.EventHandler(this.button1_Click);
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 295);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "Müşteri Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(653, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "__";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(759, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(812, 34);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "MÜŞTERİLER";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(706, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 33);
            this.button4.TabIndex = 28;
            this.button4.Text = "()";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 396);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mus_duzenle);
            this.Controls.Add(this.dgv_ekle);
            this.Controls.Add(this.btn_mus_ekle);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ekle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Button btn_mus_ekle;
        private System.Windows.Forms.DataGridView dgv_ekle;
        private System.Windows.Forms.Button btn_mus_duzenle;
        private emlakDataSet2 emlakDataSet2;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private emlakDataSet2TableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
    }
}