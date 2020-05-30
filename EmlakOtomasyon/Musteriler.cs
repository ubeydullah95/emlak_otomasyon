using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dr = veri.tabloCagir("Musteriler where Musteri_Id =" + Musteri_Id);
            veri.MusteriEkleGuncelle(Convert.ToInt32(dr.Rows[0]["Musteri_Id"]), txt_ad.Text, txt_soyad.Text, txt_telefon.Text, txt_mail.Text);
            MessageBox.Show("Müşteri güncellendi");
            this.Close();
            Musteriler mus = new Musteriler();
            mus.Show();
        }

        private void btn_mus_ekle_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            veri.MusteriEkleGuncelle(0, txt_ad.Text, txt_soyad.Text, txt_telefon.Text, txt_mail.Text);
            MessageBox.Show("İlan eklendi");
            this.Close();
            Musteriler mus = new Musteriler();
            mus.Show();

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet2.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.emlakDataSet2.Musteriler);

        }
        public int Musteri_Id;

        private void dgv_ekle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellValue=Convert.ToInt32(dgv_ekle.Rows[e.RowIndex].Cells[0].Value);
            Musteri_Id = cellValue;
            VeriTabani vt = new VeriTabani();
            DataTable dr = vt.tabloCagir("Musteriler where Musteri_Id =" + cellValue);
            txt_ad.Text = dr.Rows[0]["Musteri_Ad"].ToString();
            txt_soyad.Text = dr.Rows[0]["Musteri_Soyad"].ToString();
            txt_telefon.Text = dr.Rows[0]["Musteri_Tel"].ToString();
            txt_mail.Text = dr.Rows[0]["Musteri_Mail"].ToString();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            veri.MusteriIptal(Musteri_Id);
            MessageBox.Show("Müşteri silindi");
            this.Close();
            Musteriler mus = new Musteriler();
            mus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Musteriler mus = new Musteriler();
            mus.Show();
        }
    }
}
