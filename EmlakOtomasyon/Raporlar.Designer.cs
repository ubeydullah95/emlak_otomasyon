namespace EmlakOtomasyon
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.kiraemlakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emlakDataSet9 = new EmlakOtomasyon.emlakDataSet9();
            this.satilan_emlakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_rapor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.emlakDataSet7 = new EmlakOtomasyon.emlakDataSet7();
            this.MusterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MusterilerTableAdapter = new EmlakOtomasyon.emlakDataSet7TableAdapters.MusterilerTableAdapter();
            this.kira_emlakview = new EmlakOtomasyon.kira_emlakview();
            this.kiralanan_emlakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiralanan_emlakTableAdapter = new EmlakOtomasyon.kira_emlakviewTableAdapters.kiralanan_emlakTableAdapter();
            this.emlakDataSet8 = new EmlakOtomasyon.emlakDataSet8();
            this.kiraemlakTableAdapter = new EmlakOtomasyon.emlakDataSet9TableAdapters.kiraemlakTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.kiraemlakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satilan_emlakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kira_emlakview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralanan_emlakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // kiraemlakBindingSource
            // 
            this.kiraemlakBindingSource.DataMember = "kiraemlak";
            this.kiraemlakBindingSource.DataSource = this.emlakDataSet9;
            // 
            // emlakDataSet9
            // 
            this.emlakDataSet9.DataSetName = "emlakDataSet9";
            this.emlakDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satilan_emlakBindingSource
            // 
            this.satilan_emlakBindingSource.DataMember = "satilan_emlak";
            this.satilan_emlakBindingSource.DataSource = this.emlakDataSet9;
            // 
            // cb_rapor
            // 
            this.cb_rapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_rapor.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_rapor.ForeColor = System.Drawing.Color.White;
            this.cb_rapor.FormattingEnabled = true;
            this.cb_rapor.Items.AddRange(new object[] {
            "SATILAN EMLAKLAR",
            "KİRALANAN EMLAKLAR",
            "İLLERE GÖRE KİRALANAN EMLAKLAR",
            "İLLERE GÖRE SATILAN EMLAKLAR",
            "İLLERE GÖRE SATILAN EMLAK SAYISI",
            "İLLERE GÖRE KİRALANAN EMLAK SAYISI",
            "TÜM EMLAKLAR",
            "EMLAK TİPİNE GÖRE KİRALANAN VE SATILAN EMLAKLAR",
            "İLLERE GÖRE KİRALANAN VE SATILAN EMLAK SAYISI",
            "ISITMA TÜRÜNE GÖRE SATILAN VEYA KİRALANAN EMLAKLAR",
            "SON 1 AY SATIŞ RAPORU",
            "SON 1 YIL SATIŞ RAPORU"});
            this.cb_rapor.Location = new System.Drawing.Point(178, 52);
            this.cb_rapor.Margin = new System.Windows.Forms.Padding(2);
            this.cb_rapor.Name = "cb_rapor";
            this.cb_rapor.Size = new System.Drawing.Size(308, 21);
            this.cb_rapor.TabIndex = 0;
            this.cb_rapor.DropDown += new System.EventHandler(this.cb_rapor_DropDown);
            this.cb_rapor.SelectedIndexChanged += new System.EventHandler(this.cb_rapor_SelectedIndexChanged);
            this.cb_rapor.SelectedValueChanged += new System.EventHandler(this.cb_rapor_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(589, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(642, 0);
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
            this.pictureBox2.Location = new System.Drawing.Point(-94, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(791, 34);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "RAPORLAR";
            // 
            // emlakDataSet7
            // 
            this.emlakDataSet7.DataSetName = "emlakDataSet7";
            this.emlakDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MusterilerBindingSource
            // 
            this.MusterilerBindingSource.DataMember = "Musteriler";
            this.MusterilerBindingSource.DataSource = this.emlakDataSet7;
            // 
            // MusterilerTableAdapter
            // 
            this.MusterilerTableAdapter.ClearBeforeFill = true;
            // 
            // kira_emlakview
            // 
            this.kira_emlakview.DataSetName = "kira_emlakview";
            this.kira_emlakview.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kiralanan_emlakBindingSource
            // 
            this.kiralanan_emlakBindingSource.DataMember = "kiralanan_emlak";
            this.kiralanan_emlakBindingSource.DataSource = this.kira_emlakview;
            // 
            // kiralanan_emlakTableAdapter
            // 
            this.kiralanan_emlakTableAdapter.ClearBeforeFill = true;
            // 
            // emlakDataSet8
            // 
            this.emlakDataSet8.DataSetName = "emlakDataSet8";
            this.emlakDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kiraemlakTableAdapter
            // 
            this.kiraemlakTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(20, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(657, 579);
            this.reportViewer1.TabIndex = 28;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 696);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cb_rapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kiraemlakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet9)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.satilan_emlakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kira_emlakview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiralanan_emlakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emlakDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_rapor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource MusterilerBindingSource;
        private emlakDataSet7 emlakDataSet7;
        private emlakDataSet7TableAdapters.MusterilerTableAdapter MusterilerTableAdapter;
        private System.Windows.Forms.BindingSource kiralanan_emlakBindingSource;
        private kira_emlakview kira_emlakview;
        private kira_emlakviewTableAdapters.kiralanan_emlakTableAdapter kiralanan_emlakTableAdapter;
        private emlakDataSet8 emlakDataSet8;
        private System.Windows.Forms.BindingSource satilan_emlakBindingSource;
        private emlakDataSet9 emlakDataSet9;
        private System.Windows.Forms.BindingSource kiraemlakBindingSource;
        private emlakDataSet9TableAdapters.kiraemlakTableAdapter kiraemlakTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}