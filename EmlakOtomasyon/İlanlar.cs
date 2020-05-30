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
    public partial class İlanlar : Form
    {
        public İlanlar()
        {
            InitializeComponent();
            VeriTabani veri = new VeriTabani();
            DataTable drrr = veri.tabloCagir2("SELECT dbo.Ilanlar.Emlak_Id,  dbo.Ilanlar.Durum, dbo.Emlak_Tipi.Emlak_Tip, dbo.Il.Il_Adi +' - '+ dbo.Ilce.Ilce_Adi as Adres,FORMAT(dbo.Ilanlar.Fiyat, 'c2', 'tr-TR') as Fiyati  FROM dbo.Ilanlar INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id INNER JOIN dbo.Mahalle ON dbo.Adres.Mahalle_Id = dbo.Mahalle.Mahalle_Id INNER JOIN dbo.Ilce ON dbo.Mahalle.Ilce_Id = dbo.Ilce.Ilce_Id INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Emlak_Tipi ON dbo.Ilanlar.Tip_Id = dbo.Emlak_Tipi.Tip_Id where Aktif_Pasif=1 ");
            drrr.Columns.Add("Emlak Tipi");
            for (int i = 0; i < drrr.Rows.Count; i++)
            { 
                if (Convert.ToBoolean(drrr.Rows[i]["Durum"]) == false)
                    drrr.Rows[i]["Emlak Tipi"] = "Kiralık";
                else
                    drrr.Rows[i]["Emlak Tipi"] = "Satılık";
            }
            drrr.Columns.Remove("Durum");
            dgv_listele.DataSource = drrr;
            DataTable dt = veri.tabloCagir("Il order by Il_Adi asc");
            cb_il.DataSource = dt;
            cb_il.ValueMember = "Il_Id";
            cb_il.DisplayMember = "Il_Adi";
            cb_adresil.DataSource = dt;
            cb_adresil.ValueMember = "Il_Id";
            cb_adresil.DisplayMember = "Il_Adi";
            cb_il.SelectedIndexChanged += cb_il_SelectedValueChanged;
            cb_adresil.SelectedIndexChanged += cb_adresil_SelectedValueChanged;
            DataTable dt2 = veri.tabloCagir("Emlak_Tipi");
            cb_emlaktipi.DataSource = dt2;
            cb_emlaktipi.DisplayMember = "Emlak_Tip";
            cb_emlaktipi.ValueMember = "Tip_Id";

            dt = veri.tabloCagir("Oda_Sayisi");
            cb_odasayisi.DataSource = dt;
            cb_odasayisi.DisplayMember = "Oda_Sayi";
            cb_odasayisi.ValueMember = "Oda_Sayi_Id";
            dt = veri.tabloCagir("Bina_Yasi");
            cb_binayasi.DataSource = dt;
            cb_binayasi.DisplayMember = "Bina_Yas";
            cb_binayasi.ValueMember = "Bina_Yas_Id";
            dt = veri.tabloCagir("Isitma");
            cb_isitma.DataSource = dt;
            cb_isitma.DisplayMember = "Isitma_Turu";
            cb_isitma.ValueMember = "Isitma_Id";
            dt = veri.tabloCagir("Il order by Il_Adi asc");
            cb_adresil.DataSource = dt;
            cb_adresil.ValueMember = "Il_Id";
            cb_adresil.DisplayMember = "Il_Adi";
        }
        public int Emlak_Id;
        private void cb_adresil_SelectedValueChanged(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Ilce where Il_Id= " + cb_adresil.SelectedValue + " order by Ilce_Adi asc");
            cb_adresilce.DataSource = dt;
            cb_adresilce.ValueMember = "Ilce_Id";
            cb_adresilce.DisplayMember = "Ilce_Adi";
            cb_adresilce.SelectedIndexChanged += cb_adresilce_SelectedIndexChanged;
        }

        private void cb_adresilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Mahalle where Ilce_Id= " + cb_adresilce.SelectedValue + " order by Mahalle_Adi asc");
            cb_mahalle.ValueMember = "Mahalle_Id";
            cb_mahalle.DisplayMember = "Mahalle_Adi";
            cb_mahalle.DataSource = dt;
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            İlanEkle iekle = new İlanEkle();
            iekle.Show();
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            SatisKira satis = new SatisKira();
            satis.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable drrr = veri.tabloCagir2("SELECT dbo.Ilanlar.Emlak_Id,  dbo.Ilanlar.Durum, dbo.Emlak_Tipi.Emlak_Tip, dbo.Il.Il_Adi +' - '+ dbo.Ilce.Ilce_Adi as Adres,FORMAT(dbo.Ilanlar.Fiyat, 'c2', 'tr-TR') as Fiyati  FROM dbo.Ilanlar INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id INNER JOIN dbo.Mahalle ON dbo.Adres.Mahalle_Id = dbo.Mahalle.Mahalle_Id INNER JOIN dbo.Ilce ON dbo.Mahalle.Ilce_Id = dbo.Ilce.Ilce_Id INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Emlak_Tipi ON dbo.Ilanlar.Tip_Id = dbo.Emlak_Tipi.Tip_Id where Aktif_Pasif=1 and dbo.Ilce.Ilce_Id =" + cb_ilce.SelectedValue +" and dbo.Ilanlar.Durum ="+Convert.ToInt32(rb_kiralik.Checked)+" and dbo.Ilanlar.Tip_Id ="+cb_emlaktipi.SelectedValue);
            drrr.Columns.Add("Emlak Tipi");
            for (int i = 0; i < drrr.Rows.Count; i++)
            {
                if (Convert.ToBoolean(drrr.Rows[i]["Durum"]) == false)
                    drrr.Rows[i]["Emlak Tipi"] = "Kiralık";
                else
                    drrr.Rows[i]["Emlak Tipi"] = "Satılık";
            }
            dgv_listele.DataSource = drrr;

        }
        private void cb_il_SelectedValueChanged(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Ilce where Il_Id= " + cb_il.SelectedValue + " order by Ilce_Adi asc");
            cb_ilce.ValueMember = "Ilce_Id";
            cb_ilce.DisplayMember = "Ilce_Adi";
            cb_ilce.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void İlanlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kira_emlakview.kiralanan_emlak' table. You can move, or remove it, as needed.
            //this.kiralanan_emlakTableAdapter.Fill(this.kira_emlakview.kiralanan_emlak);
            // TODO: This line of code loads data into the 'emlakDataSet5.View_2' table. You can move, or remove it, as needed.
            this.view_2TableAdapter.Fill(this.emlakDataSet5.View_2);
            // TODO: This line of code loads data into the 'emlakDataSet3.Ilanlar' table. You can move, or remove it, as needed.
            this.ilanlarTableAdapter.Fill(this.emlakDataSet3.Ilanlar);
            // TODO: This line of code loads data into the 'emlakDataSet.View_1' table. You can move, or remove it, as needed.
            this.view_1TableAdapter.Fill(this.emlakDataSet.View_1);
            // TODO: This line of code loads data into the 'emlakDataSet1.Ilanlar' table. You can move, or remove it, as needed.

        }

        private void dgv_listele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            İlanlar.ActiveForm.Refresh();
        }
        private void dgv_listele_DoubleClick(object sender, EventArgs e)
        {


        }
        private void dgv_listele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellValue = Convert.ToInt32(dgv_listele.Rows[e.RowIndex].Cells[0].Value);
            Emlak_Id = cellValue;
            VeriTabani vt = new VeriTabani();
            DataTable dr = vt.tabloCagir("Ilanlar where Emlak_Id =" + cellValue);
            DataTable drO = vt.tabloCagir("Ozellikler where Ozellik_Id=" + Convert.ToInt32(dr.Rows[0]["Ozellik_Id"]));
            txt_fiyat.Text = dr.Rows[0]["Fiyat"].ToString();
            txt_aciklama.Text=dr.Rows[0]["Aciklama"].ToString();
            txt_metrekare.Text = drO.Rows[0]["Ev_Metre"].ToString();
            cb_odasayisi.SelectedValue = Convert.ToInt32(drO.Rows[0]["Oda_Sayi_Id"]);
            txt_banyosayisi.Text = drO.Rows[0]["Banyo_Sayisi"].ToString();
            cb_binayasi.SelectedValue = Convert.ToInt32(drO.Rows[0]["Bina_Yas_Id"]);
            txt_kat.Text = drO.Rows[0]["Bulundugu_Kat"].ToString();
            cb_isitma.SelectedValue = Convert.ToInt32(drO.Rows[0]["Isitma_Id"]);
            //  chb_esya.Checked= drO.Rows[0]["Ev_Esya"];
            DataTable drA = vt.tabloCagir("Adres where Adres_Id=" + Convert.ToInt32(dr.Rows[0]["Adres_Id"]));
            txt_acikadres.Text = drA.Rows[0]["Acik_Adres"].ToString();

            int Mahalle_Id = Convert.ToInt32(drA.Rows[0]["Mahalle_Id"]);
            int Ilce_Id = Convert.ToInt32(vt.tabloCagir("Mahalle where Mahalle_Id =" + Mahalle_Id).Rows[0]["Ilce_Id"]);
            int Il_Id = Convert.ToInt32(vt.tabloCagir("Ilce where Ilce_Id =" + Ilce_Id).Rows[0]["Il_Id"]);

            // cb_adresil.SelectedValueChanged -= cb_adresil_SelectedValueChanged;
            // cb_adresil.SelectedValueChanged += cb_adresil_SelectedValueChanged_1;
            cb_adresil.SelectedValue = Il_Id;
            // cb_adresilce.SelectedValueChanged -= cb_adresilce_SelectedIndexChanged;
            //cb_adresilce.SelectedValueChanged += cb_adresilce_SelectedValueChanged_1;
            cb_adresilce.SelectedValue = Ilce_Id;
            cb_mahalle.SelectedValue = Mahalle_Id;

            DataTable drD = vt.tabloCagir("Diger_Ozellikler where Diger_Id=" + Convert.ToInt32(dr.Rows[0]["Diger_Id"]));
            chb_otopark.Checked = Convert.ToBoolean(drD.Rows[0]["D_Otopark"]);
            chb_alarm.Checked = Convert.ToBoolean(drD.Rows[0]["D_Alarm"]);
            chb_asansor.Checked = Convert.ToBoolean(drD.Rows[0]["D_Asansor"]);
            chb_guvenlik.Checked = Convert.ToBoolean(drD.Rows[0]["D_Guvenlik"]);
            chb_havuz.Checked = Convert.ToBoolean(drD.Rows[0]["D_Havuz"]);

        }
        private void cb_adresilce_SelectedValueChanged_1(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Mahalle where Ilce_Id= " + cb_adresilce.SelectedValue + " order by Ilce_Adi asc");
            cb_mahalle.ValueMember = "Mahalle_Id";
            cb_mahalle.DisplayMember = "Mahalle_Adi";
            cb_mahalle.DataSource = dt;
        }
        private void cb_adresil_SelectedValueChanged_1(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dt = veri.tabloCagir("Ilce where Il_Id= " + cb_adresil.SelectedValue + " order by Ilce_Adi asc");
            cb_adresilce.ValueMember = "Ilce_Id";
            cb_adresilce.DisplayMember = "Ilce_Adi";
            cb_adresilce.DataSource = dt;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            DataTable dr = veri.tabloCagir("Ilanlar where Emlak_Id =" + Emlak_Id);

            int Ozellikler, DigerOzellikler, Adres, Ekle;
            bool durum = false;
            if (chb_esya.Checked == true)
                durum = true;
            Ozellikler = veri.Ozellikler(Convert.ToInt32(dr.Rows[0]["Ozellik_Id"]), Convert.ToInt32(txt_metrekare.Text), Convert.ToInt32(cb_odasayisi.SelectedValue), Convert.ToInt32(txt_banyosayisi.Text), Convert.ToInt32(cb_binayasi.SelectedValue), Convert.ToInt32(txt_kat.Text), Convert.ToInt32(cb_isitma.SelectedValue), durum);
            DigerOzellikler = veri.Diger_Ozellikler(Convert.ToInt32(dr.Rows[0]["Diger_Id"]), chb_otopark.Checked, chb_asansor.Checked, chb_guvenlik.Checked, chb_havuz.Checked, chb_alarm.Checked);
            Adres = veri.Adres(Convert.ToInt32(dr.Rows[0]["Adres_Id"]), txt_acikadres.Text, Convert.ToInt32(cb_mahalle.SelectedValue));
            durum = true;
            if (rb_kiralik.Checked == true)
                durum = false;
            Ekle = veri.IlanEkleGuncelle(Convert.ToInt32(dr.Rows[0]["Emlak_Id"]), durum, Convert.ToInt32(cb_emlaktipi.SelectedValue), Convert.ToInt32(txt_fiyat.Text), Ozellikler, Adres, txt_aciklama.Text, DigerOzellikler, true);
            MessageBox.Show("İlan güncellendi");
            Close();
            İlanlar ilan = new İlanlar();
            ilan.Show();         
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            veri.IlanIptal(Emlak_Id);
            MessageBox.Show("İlan silindi");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ılanlarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void view1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
            İlanlar ilan = new İlanlar();
            ilan.Show();
        }
    }
}
