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
    public partial class İlanEkle : Form
    {
        public İlanEkle()
        {
            InitializeComponent();
        }

        private void İlanEkle_Load(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt2 = veri.tabloCagir("Emlak_Tipi");
            cb_emlaktipi.DataSource = dt2;
            cb_emlaktipi.DisplayMember = "Emlak_Tip";
            cb_emlaktipi.ValueMember = "Tip_Id";
            dt2 = veri.tabloCagir("Oda_Sayisi");
            cb_odasayisi.DataSource = dt2;
            cb_odasayisi.DisplayMember = "Oda_Sayi";
            cb_odasayisi.ValueMember = "Oda_Sayi_Id";
            dt2 = veri.tabloCagir("Bina_Yasi");
            cb_binayasi.DataSource = dt2;
            cb_binayasi.DisplayMember = "Bina_Yas";
            cb_binayasi.ValueMember = "Bina_Yas_Id";
            dt2 = veri.tabloCagir("Isitma");
            cb_isitma.DataSource = dt2;
            cb_isitma.DisplayMember = "Isitma_Turu";
            cb_isitma.ValueMember = "Isitma_Id";
            DataTable dt = veri.tabloCagir("Il order by Il_Adi asc");
            cb_il.DataSource = dt;
            cb_il.ValueMember = "Il_Id";
            cb_il.DisplayMember = "Il_Adi";
            cb_il.SelectedIndexChanged += cb_il_SelectedValueChanged;
        }
        private void cb_il_SelectedValueChanged(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Ilce where Il_Id= " + cb_il.SelectedValue + " order by Ilce_Adi asc");
            cb_ilce.DataSource = dt;
            cb_ilce.ValueMember = "Ilce_Id";
            cb_ilce.DisplayMember = "Ilce_Adi";
            cb_ilce.SelectedIndexChanged += cb_ilce_SelectedIndexChanged;
        }

        private void cb_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Mahalle where Ilce_Id= " + cb_ilce.SelectedValue + " order by Mahalle_Adi asc");
            cb_mahalle.ValueMember = "Mahalle_Id";
            cb_mahalle.DisplayMember = "Mahalle_Adi";
            cb_mahalle.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            int Ozellikler, DigerOzellikler, Adres, Ekle;
            bool durum = false;
            if (chb_esya.Checked == true)
                durum = true;
            Ozellikler = veri.Ozellikler(0, Convert.ToInt32(txt_metrekare.Text), Convert.ToInt32(cb_odasayisi.SelectedValue), Convert.ToInt32(txt_banyosayisi.Text), Convert.ToInt32(cb_binayasi.SelectedValue), Convert.ToInt32(txt_kat.Text), Convert.ToInt32(cb_isitma.SelectedValue), durum);
            DigerOzellikler = veri.Diger_Ozellikler(0, chb_otopark.Checked, chb_asansor.Checked, chb_guvenlik.Checked, chb_havuz.Checked, chb_alarm.Checked);
            Adres = veri.Adres(0, txt_acıkadres.Text, Convert.ToInt32(cb_mahalle.SelectedValue));
            durum = true;
            if (rb_kiralik.Checked == true)
                durum = false;
            Ekle = veri.IlanEkleGuncelle(0, durum,Convert.ToInt32( cb_emlaktipi.SelectedValue), Convert.ToInt32(txt_fiyat.Text), Ozellikler, Adres, txt_aciklama.Text, DigerOzellikler, true);
            MessageBox.Show("İlan eklendi");
            this.Close();
            
        }

        private void İlanEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            İlanlar ilan = new İlanlar();
            ilan.Show();
        }

        private void txt_aciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_kiralik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_satilik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_emlaktipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_fiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void chb_esya_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb_odasayisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_isitma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cb_binayasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_kat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txt_banyosayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_metrekare_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cb_mahalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cb_ilce_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cb_il_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_acıkadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void chb_alarm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_havuz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_guvenlik_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_asansor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_otopark_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtp_tarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
