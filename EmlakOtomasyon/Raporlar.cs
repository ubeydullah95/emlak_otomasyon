using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmlakOtomasyon
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet9.kiraemlak' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'emlakDataSet9.satilan_emlak' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'emlakDataSet9.kiralanan_emlak' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'emlakDataSet9.kiralanan_emlak' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'emlakDataSet9.satilan_emlak' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'emlakDataSet8.kiralanan_emlak' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'kira_emlakview.kiralanan_emlak' table. You can move, or remove it, as needed.
            //this.kiralanan_emlakTableAdapter.Fill(this.kira_emlakview.kiralanan_emlak);
            // TODO: This line of code loads data into the 'emlakDataSet7.Musteriler' table. You can move, or remove it, as needed.




            //  this.kiralanan_emlakTableAdapter.Fill(this.yenidataset.kiralanan_emlak);
            /*kira_emlakview.kiralanan_emlakDataTable aa = new kira_emlakview.kiralanan_emlakDataTable();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource dt = new ReportDataSource("DataSet1",(DataTable)aa);
            reportViewer1.LocalReport.DataSources.Add(dt);*/
            //  reportViewer1.LocalReport.Refresh();
            // reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_ReportExport(object sender, Microsoft.Reporting.WinForms.ReportExportEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cb_rapor_DropDown(object sender, EventArgs e)
        {

        }

        private void cb_rapor_SelectedValueChanged(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            DataTable dt1 = new DataTable();
            if (cb_rapor.SelectedIndex == 0)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Kayitlar.Satis_Fiyati, dbo.Ilanlar.Fiyat, dbo.Ilanlar.Emlak_Id, dbo.Musteriler.Musteri_Ad + ' ' + dbo.Musteriler.Musteri_Soyad AS AdSoyad FROM dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1)");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.ReportSatilan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 1)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Kayitlar.Satis_Fiyati, dbo.Ilanlar.Fiyat, dbo.Ilanlar.Emlak_Id, dbo.Musteriler.Musteri_Ad + ' ' + dbo.Musteriler.Musteri_Soyad AS AdSoyad FROM dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0)");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.ReportKiralanan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 2)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, SUM(dbo.Ilanlar.Fiyat) AS Fiyat, SUM(dbo.Kayitlar.Satis_Fiyati) AS SatisFiyati FROM dbo.Ilce INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) GROUP BY dbo.Il.Il_Adi");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.ReportIlleregoresatilan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 3)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, SUM(dbo.Ilanlar.Fiyat) AS Fiyat, SUM(dbo.Kayitlar.Satis_Fiyati) AS SatisFiyati FROM dbo.Ilce INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0) GROUP BY dbo.Il.Il_Adi");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportilleregorekiralanan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 4)//illere gore kaç adet ne kadar satilmis
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, COUNT(dbo.Ilanlar.Fiyat) AS SatisAdet,  SUM(dbo.Ilanlar.Fiyat) AS Fiyat, SUM(dbo.Kayitlar.Satis_Fiyati) AS SatisFiyati FROM dbo.Ilce INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) GROUP BY dbo.Il.Il_Adi");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportilleregoretoplamsatilan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 5)//illere gore kaç adet ne kadar kiralanmış
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, COUNT(dbo.Ilanlar.Fiyat) AS SatisAdet,  SUM(dbo.Ilanlar.Fiyat) AS Fiyat, SUM(dbo.Kayitlar.Satis_Fiyati) AS SatisFiyati FROM dbo.Ilce INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0) GROUP BY dbo.Il.Il_Adi");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportilleregoretoplamkiralanan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 6)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Ilanlar.Emlak_Id, dbo.Kayitlar.Satis_Fiyati, dbo.Ilanlar.Fiyat, dbo.Kayitlar.Satis_Fiyati - dbo.Ilanlar.Fiyat AS Kar, 'Kiralık' AS Emlak FROM dbo.Ilanlar INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) UNION SELECT dbo.Ilanlar.Emlak_Id, dbo.Kayitlar.Satis_Fiyati, dbo.Ilanlar.Fiyat, dbo.Kayitlar.Satis_Fiyati - dbo.Ilanlar.Fiyat AS Kar, 'Satilan' AS Emlak FROM dbo.Ilanlar INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0)");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportemlakhepsi.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 7)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Emlak_Tipi.Emlak_Tip, 'Kiralık' AS EmlakTip, COUNT(dbo.Emlak_Tipi.Emlak_Tip) AS Adet FROM dbo.Ilanlar INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Emlak_Tipi ON dbo.Ilanlar.Tip_Id = dbo.Emlak_Tipi.Tip_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) GROUP BY dbo.Emlak_Tipi.Emlak_Tip, dbo.Ilanlar.Durum UNION SELECT dbo.Emlak_Tipi.Emlak_Tip, 'Satilik' AS EmlakTip, COUNT(dbo.Emlak_Tipi.Emlak_Tip) AS Adet FROM dbo.Ilanlar INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Emlak_Tipi ON dbo.Ilanlar.Tip_Id = dbo.Emlak_Tipi.Tip_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0) GROUP BY dbo.Emlak_Tipi.Emlak_Tip, dbo.Ilanlar.Durum");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportemlaktipinegorekiralananvesatilan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 8)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, 'Kiralanan' AS Emlak, COUNT(dbo.Ilanlar.Fiyat) AS SatisAdet, SUM(dbo.Ilanlar.Fiyat) AS Fiyat, SUM(dbo.Kayitlar.Satis_Fiyati) AS SatisFiyati FROM dbo.Ilce INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) GROUP BY dbo.Il.Il_Adi UNION SELECT dbo.Il.Il_Adi, 'Satilan' AS Emlak, COUNT(dbo.Ilanlar.Fiyat) AS SatisAdet, SUM(dbo.Ilanlar.Fiyat) AS Fiyat, SUM(dbo.Kayitlar.Satis_Fiyati) AS SatisFiyati FROM dbo.Ilce INNER JOIN dbo.Il ON dbo.Ilce.Il_Id = dbo.Il.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Kayitlar INNER JOIN dbo.Ilanlar ON dbo.Kayitlar.Emlak_Id = dbo.Ilanlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id INNER JOIN dbo.Adres ON dbo.Ilanlar.Adres_Id = dbo.Adres.Adres_Id ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0) GROUP BY dbo.Il.Il_Adi");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportilleregoretoplam.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 9)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Isitma.Isitma_Turu, 'Kiralık' AS EmlakTip, COUNT(dbo.Isitma.Isitma_Turu) AS Adet FROM dbo.Ilanlar INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Ozellikler ON dbo.Ilanlar.Ozellik_Id = dbo.Ozellikler.Ozellik_Id INNER JOIN dbo.Isitma ON dbo.Ozellikler.Isitma_Id = dbo.Isitma.Isitma_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) GROUP BY dbo.Isitma.Isitma_Turu UNION SELECT dbo.Isitma.Isitma_Turu, 'Satilik' AS EmlakTip, COUNT(dbo.Isitma.Isitma_Turu) AS Adet FROM dbo.Ilanlar INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Ozellikler ON dbo.Ilanlar.Ozellik_Id = dbo.Ozellikler.Ozellik_Id INNER JOIN dbo.Isitma ON dbo.Ozellikler.Isitma_Id = dbo.Isitma.Isitma_Id WHERE(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0) GROUP BY dbo.Isitma.Isitma_Turu");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportisitmatipinegorekiralananvesatilan.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 10)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, dbo.Ilanlar.Emlak_Id, dbo.Musteriler.Musteri_Ad + '  ' + dbo.Musteriler.Musteri_Soyad AS AdSoyad, dbo.Kayitlar.V_Tarih, dbo.Kayitlar.Satis_Fiyati - dbo.Ilanlar.Fiyat AS Kar, 'Satılık' AS Emlak FROM dbo.Il INNER JOIN dbo.Ilce ON dbo.Il.Il_Id = dbo.Ilce.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Adres ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id INNER JOIN dbo.Ilanlar ON dbo.Adres.Adres_Id = dbo.Ilanlar.Adres_Id INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id WHERE dbo.Kayitlar.V_Tarih BETWEEN CAST(GETDATE() - 30 AS DATE) AND CAST(GETDATE() AS DATE) AND(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) UNION SELECT dbo.Il.Il_Adi, dbo.Ilanlar.Emlak_Id, dbo.Musteriler.Musteri_Ad + '  ' + dbo.Musteriler.Musteri_Soyad AS AdSoyad, dbo.Kayitlar.V_Tarih, dbo.Kayitlar.Satis_Fiyati - dbo.Ilanlar.Fiyat AS Kar, 'Kiralık' AS Emlak FROM dbo.Il INNER JOIN dbo.Ilce ON dbo.Il.Il_Id = dbo.Ilce.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Adres ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id INNER JOIN dbo.Ilanlar ON dbo.Adres.Adres_Id = dbo.Ilanlar.Adres_Id INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id WHERE dbo.Kayitlar.V_Tarih BETWEEN CAST(GETDATE() - 30 AS DATE) AND CAST(GETDATE() AS DATE) AND(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0)");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportayliksatis.rdlc";
            }
            else if (cb_rapor.SelectedIndex == 11)
            {
                dt1 = vt.tabloCagir2("SELECT dbo.Il.Il_Adi, dbo.Ilanlar.Emlak_Id, dbo.Musteriler.Musteri_Ad + '  ' + dbo.Musteriler.Musteri_Soyad AS AdSoyad, dbo.Kayitlar.V_Tarih, dbo.Kayitlar.Satis_Fiyati - dbo.Ilanlar.Fiyat AS Kar, 'Satılık' AS Emlak FROM dbo.Il INNER JOIN dbo.Ilce ON dbo.Il.Il_Id = dbo.Ilce.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Adres ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id INNER JOIN dbo.Ilanlar ON dbo.Adres.Adres_Id = dbo.Ilanlar.Adres_Id INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id WHERE dbo.Kayitlar.V_Tarih BETWEEN CAST(GETDATE() - 365 AS DATE) AND CAST(GETDATE() AS DATE) AND(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 1) UNION SELECT dbo.Il.Il_Adi, dbo.Ilanlar.Emlak_Id, dbo.Musteriler.Musteri_Ad + '  ' + dbo.Musteriler.Musteri_Soyad AS AdSoyad, dbo.Kayitlar.V_Tarih, dbo.Kayitlar.Satis_Fiyati - dbo.Ilanlar.Fiyat AS Kar, 'Kiralık' AS Emlak FROM dbo.Il INNER JOIN dbo.Ilce ON dbo.Il.Il_Id = dbo.Ilce.Il_Id INNER JOIN dbo.Mahalle ON dbo.Ilce.Ilce_Id = dbo.Mahalle.Ilce_Id INNER JOIN dbo.Adres ON dbo.Mahalle.Mahalle_Id = dbo.Adres.Mahalle_Id INNER JOIN dbo.Ilanlar ON dbo.Adres.Adres_Id = dbo.Ilanlar.Adres_Id INNER JOIN dbo.Kayitlar ON dbo.Ilanlar.Emlak_Id = dbo.Kayitlar.Emlak_Id INNER JOIN dbo.Musteriler ON dbo.Kayitlar.Musteri_Id = dbo.Musteriler.Musteri_Id WHERE dbo.Kayitlar.V_Tarih BETWEEN CAST(GETDATE() - 365 AS DATE) AND CAST(GETDATE() AS DATE) AND(dbo.Ilanlar.Aktif_Pasif = 0) AND(dbo.Ilanlar.Durum = 0)");
                reportViewer1.LocalReport.ReportEmbeddedResource = "EmlakOtomasyon.Reportyilliksatis.rdlc";
            }
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource dt = new ReportDataSource("DataSet1", dt1);
            reportViewer1.LocalReport.DataSources.Add(dt);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {



        }

        private void btn_goster_Click(object sender, EventArgs e)
        {

        }

        private void cb_rapor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
