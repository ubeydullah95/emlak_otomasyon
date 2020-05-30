namespace EmlakOtomasyon
{
    partial class SatisKira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisKira));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musterilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet6 = new EmlakOtomasyon.emlakDataSet6();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet4 = new EmlakOtomasyon.emlakDataSet4();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.musterilerTableAdapter = new EmlakOtomasyon.emlakDataSet4TableAdapters.MusterilerTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.musterilerTableAdapter1 = new EmlakOtomasyon.emlakDataSet6TableAdapters.MusterilerTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.emlakDataSet12 = new EmlakOtomasyon.emlakDataSet12();
            this.ıptalIslemiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iptalIslemiTableAdapter = new EmlakOtomasyon.emlakDataSet12TableAdapters.IptalIslemiTableAdapter();
            this.emlakIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlakTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılceAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahalleAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.emlakDataSet13 = new EmlakOtomasyon.emlakDataSet13();
            this.musterilerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter2 = new EmlakOtomasyon.emlakDataSet13TableAdapters.MusterilerTableAdapter();
            this.Musteri_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musteri_Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musteri_Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musteri_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Musteri_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıptalIslemiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Musteri_Id,
            this.Musteri_Ad,
            this.Musteri_Soyad,
            this.Musteri_Tel,
            this.Musteri_Mail});
            this.dataGridView1.DataSource = this.musterilerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(278, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 211);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // musterilerBindingSource1
            // 
            this.musterilerBindingSource1.DataMember = "Musteriler";
            this.musterilerBindingSource1.DataSource = this.emlakDataSet6;
            // 
            // emlakDataSet6
            // 
            this.emlakDataSet6.DataSetName = "emlakDataSet6";
            this.emlakDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.emlakDataSet4;
            // 
            // emlakDataSet4
            // 
            this.emlakDataSet4.DataSetName = "emlakDataSet4";
            this.emlakDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Emlak No:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(105, 49);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 21);
            this.textBox4.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Satış Tarihi :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(105, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 21);
            this.textBox1.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 89);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Satış Fiyatı :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(105, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(105, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 38);
            this.button2.TabIndex = 27;
            this.button2.Text = " Müşteri Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(663, 1);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "__";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(771, 1);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 33);
            this.button4.TabIndex = 30;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(806, 34);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "SATIŞ VE KİRALAMA";
            // 
            // musterilerTableAdapter1
            // 
            this.musterilerTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(717, 1);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 33);
            this.button5.TabIndex = 32;
            this.button5.Text = "()";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emlakIdDataGridViewTextBoxColumn,
            this.emlakTipDataGridViewTextBoxColumn,
            this.musteriIdDataGridViewTextBoxColumn1,
            this.adSoyadDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.satisFiyatiDataGridViewTextBoxColumn,
            this.ılAdiDataGridViewTextBoxColumn,
            this.ılceAdiDataGridViewTextBoxColumn,
            this.mahalleAdiDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ıptalIslemiBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(278, 330);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(535, 211);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // emlakDataSet12
            // 
            this.emlakDataSet12.DataSetName = "emlakDataSet12";
            this.emlakDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıptalIslemiBindingSource
            // 
            this.ıptalIslemiBindingSource.DataMember = "IptalIslemi";
            this.ıptalIslemiBindingSource.DataSource = this.emlakDataSet12;
            // 
            // iptalIslemiTableAdapter
            // 
            this.iptalIslemiTableAdapter.ClearBeforeFill = true;
            // 
            // emlakIdDataGridViewTextBoxColumn
            // 
            this.emlakIdDataGridViewTextBoxColumn.DataPropertyName = "Emlak_Id";
            this.emlakIdDataGridViewTextBoxColumn.HeaderText = "Emlak_Id";
            this.emlakIdDataGridViewTextBoxColumn.Name = "emlakIdDataGridViewTextBoxColumn";
            // 
            // emlakTipDataGridViewTextBoxColumn
            // 
            this.emlakTipDataGridViewTextBoxColumn.DataPropertyName = "Emlak_Tip";
            this.emlakTipDataGridViewTextBoxColumn.HeaderText = "Emlak_Tip";
            this.emlakTipDataGridViewTextBoxColumn.Name = "emlakTipDataGridViewTextBoxColumn";
            // 
            // musteriIdDataGridViewTextBoxColumn1
            // 
            this.musteriIdDataGridViewTextBoxColumn1.DataPropertyName = "Musteri_Id";
            this.musteriIdDataGridViewTextBoxColumn1.HeaderText = "Musteri_Id";
            this.musteriIdDataGridViewTextBoxColumn1.Name = "musteriIdDataGridViewTextBoxColumn1";
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // satisFiyatiDataGridViewTextBoxColumn
            // 
            this.satisFiyatiDataGridViewTextBoxColumn.DataPropertyName = "Satis_Fiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.HeaderText = "Satis_Fiyati";
            this.satisFiyatiDataGridViewTextBoxColumn.Name = "satisFiyatiDataGridViewTextBoxColumn";
            // 
            // ılAdiDataGridViewTextBoxColumn
            // 
            this.ılAdiDataGridViewTextBoxColumn.DataPropertyName = "Il_Adi";
            this.ılAdiDataGridViewTextBoxColumn.HeaderText = "Il_Adi";
            this.ılAdiDataGridViewTextBoxColumn.Name = "ılAdiDataGridViewTextBoxColumn";
            // 
            // ılceAdiDataGridViewTextBoxColumn
            // 
            this.ılceAdiDataGridViewTextBoxColumn.DataPropertyName = "Ilce_Adi";
            this.ılceAdiDataGridViewTextBoxColumn.HeaderText = "Ilce_Adi";
            this.ılceAdiDataGridViewTextBoxColumn.Name = "ılceAdiDataGridViewTextBoxColumn";
            // 
            // mahalleAdiDataGridViewTextBoxColumn
            // 
            this.mahalleAdiDataGridViewTextBoxColumn.DataPropertyName = "Mahalle_Adi";
            this.mahalleAdiDataGridViewTextBoxColumn.HeaderText = "Mahalle_Adi";
            this.mahalleAdiDataGridViewTextBoxColumn.Name = "mahalleAdiDataGridViewTextBoxColumn";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(105, 407);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 38);
            this.button6.TabIndex = 34;
            this.button6.Text = "Satış İptal";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // emlakDataSet13
            // 
            this.emlakDataSet13.DataSetName = "emlakDataSet13";
            this.emlakDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource2
            // 
            this.musterilerBindingSource2.DataMember = "Musteriler";
            this.musterilerBindingSource2.DataSource = this.emlakDataSet13;
            // 
            // musterilerTableAdapter2
            // 
            this.musterilerTableAdapter2.ClearBeforeFill = true;
            // 
            // Musteri_Id
            // 
            this.Musteri_Id.DataPropertyName = "Musteri_Id";
            this.Musteri_Id.HeaderText = "Musteri_Id";
            this.Musteri_Id.Name = "Musteri_Id";
            this.Musteri_Id.ReadOnly = true;
            // 
            // Musteri_Ad
            // 
            this.Musteri_Ad.DataPropertyName = "Musteri_Ad";
            this.Musteri_Ad.HeaderText = "Musteri_Ad";
            this.Musteri_Ad.Name = "Musteri_Ad";
            // 
            // Musteri_Soyad
            // 
            this.Musteri_Soyad.DataPropertyName = "Musteri_Soyad";
            this.Musteri_Soyad.HeaderText = "Musteri_Soyad";
            this.Musteri_Soyad.Name = "Musteri_Soyad";
            // 
            // Musteri_Tel
            // 
            this.Musteri_Tel.DataPropertyName = "Musteri_Tel";
            this.Musteri_Tel.HeaderText = "Musteri_Tel";
            this.Musteri_Tel.Name = "Musteri_Tel";
            // 
            // Musteri_Mail
            // 
            this.Musteri_Mail.DataPropertyName = "Musteri_Mail";
            this.Musteri_Mail.HeaderText = "Musteri_Mail";
            this.Musteri_Mail.Name = "Musteri_Mail";
            // 
            // SatisKira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 565);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SatisKira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisKira";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SatisKira_FormClosed);
            this.Load += new System.EventHandler(this.SatisKira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıptalIslemiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private emlakDataSet4 emlakDataSet4;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private emlakDataSet4TableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private emlakDataSet6 emlakDataSet6;
        private System.Windows.Forms.BindingSource musterilerBindingSource1;
        private emlakDataSet6TableAdapters.MusterilerTableAdapter musterilerTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private emlakDataSet12 emlakDataSet12;
        private System.Windows.Forms.BindingSource ıptalIslemiBindingSource;
        private emlakDataSet12TableAdapters.IptalIslemiTableAdapter iptalIslemiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlakIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlakTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılceAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahalleAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private emlakDataSet13 emlakDataSet13;
        private System.Windows.Forms.BindingSource musterilerBindingSource2;
        private emlakDataSet13TableAdapters.MusterilerTableAdapter musterilerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri_Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Musteri_Mail;
    }
}