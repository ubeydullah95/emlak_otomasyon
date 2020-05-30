using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace EmlakOtomasyon
{
    class VeriTabani
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-OBBRT93; Initial Catalog = emlak; Integrated Security = True");
            return baglanti;
        }
        public DataTable tabloCagir2(string sorgu)
        {

            SqlConnection baglan = this.baglan();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter(sorgu, baglan);
            try
            {
                adaptor.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            adaptor.Dispose();
            baglan.Close();
            return dt;

        }
        public DataTable tabloCagir(string tabloAd)
        {
            string sorgu = "select * from " + tabloAd;
            SqlConnection baglan = this.baglan();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter(sorgu, baglan);
            try
            {
                adaptor.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }
            adaptor.Dispose();
            baglan.Close();
            return dt;
        }
        public void Satis(int Emlak_Id, int Musteri_Id, DateTime V_Tarih, int Satis_Fiyati)
        {
            SqlCommand sorgu = new SqlCommand();
            sorgu.CommandText = "insert into Kayitlar(Emlak_Id,Musteri_Id,V_Tarih,Satis_Fiyati) values (@Emlak_Id,@Musteri_Id,@V_Tarih,@Satis_Fiyati); update Ilanlar set Aktif_Pasif=0 where Emlak_Id= @Emlak_Id2  ";

            SqlConnection baglan = this.baglan();
            sorgu.Connection = baglan;
            sorgu.Parameters.AddWithValue("@Emlak_Id", Emlak_Id);
            sorgu.Parameters.AddWithValue("@Musteri_Id", Musteri_Id);
            sorgu.Parameters.AddWithValue("@V_Tarih", V_Tarih);
            sorgu.Parameters.AddWithValue("@Satis_Fiyati", Satis_Fiyati);
            sorgu.Parameters.AddWithValue("@Emlak_Id2", Emlak_Id);
            try
            {
                baglan.Open();
                int a = sorgu.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            baglan.Close();
        }


        public int MusteriEkleGuncelle(int Musteri_Id, string Musteri_Ad, string Musteri_Soyad, string Musteri_Tel, string Musteri_Mail)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            if (Musteri_Id > 0)
                komut.CommandText = "update Musteriler set Musteri_Ad=@Musteri_Ad, Musteri_Soyad=@Musteri_Soyad, Musteri_Tel=@Musteri_Tel, Musteri_Mail=@Musteri_Mail  where Musteri_Id=@Musteri_Id";
            else
                komut.CommandText = "insert into Musteriler(Musteri_Ad, Musteri_Soyad, Musteri_Tel, Musteri_Mail) values (@Musteri_Ad, @Musteri_Soyad, @Musteri_Tel, @Musteri_Mail)";
            komut.Parameters.AddWithValue("@Musteri_Ad", Musteri_Ad);
            komut.Parameters.AddWithValue("@Musteri_Soyad", Musteri_Soyad);
            komut.Parameters.AddWithValue("@Musteri_Tel", Musteri_Tel);
            komut.Parameters.AddWithValue("@Musteri_Mail", Musteri_Mail);
            if (Musteri_Id > 0)
                komut.Parameters.AddWithValue("@Musteri_Id", Musteri_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
                if (Musteri_Id <= 0)
                {
                    komut.CommandText = "select @@IDENTITY as sonuc order by sonuc desc";
                    SqlDataReader dr = komut.ExecuteReader();
                    dr.Read();
                    sonuc = Convert.ToInt32(dr["sonuc"]);
                    dr.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            baglan.Close();
            baglan.Dispose();
            komut.Dispose();
            return sonuc;

        }
        public int IlanEkleGuncelle(int Emlak_Id, bool Durum, int Tip_Id, int Fiyat, int Ozellik_Id, int Adres_Id, string Aciklama, int Diger_Id, bool Aktif_Pasif)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            if (Emlak_Id > 0)
                komut.CommandText = "update Ilanlar set Durum=@Durum, Tip_Id=@Tip_Id, Fiyat=@Fiyat, Ozellik_Id=@Ozellik_Id, Adres_Id=@Adres_Id, Aciklama=@Aciklama,Diger_Id=@Diger_Id, Aktif_Pasif=@Aktif_Pasif  where Emlak_Id=@Emlak_Id";
            else
                komut.CommandText = "insert into Ilanlar(Durum, Tip_Id, Fiyat, Ozellik_Id, Adres_Id, Aciklama, Diger_Id, Aktif_Pasif) values (@Durum, @Tip_Id, @Fiyat, @Ozellik_Id, @Adres_Id, @Aciklama, @Diger_Id, @Aktif_Pasif)";
            komut.Parameters.AddWithValue("@Durum", Durum);
            komut.Parameters.AddWithValue("@Tip_Id", Tip_Id);
            komut.Parameters.AddWithValue("@Fiyat", Fiyat);
            komut.Parameters.AddWithValue("@Ozellik_Id", Ozellik_Id);
            komut.Parameters.AddWithValue("@Adres_Id", Adres_Id);
            komut.Parameters.AddWithValue("@Aciklama", Aciklama);
            komut.Parameters.AddWithValue("@Diger_Id", Diger_Id);
            komut.Parameters.AddWithValue("@Aktif_Pasif", Aktif_Pasif);
            if (Emlak_Id > 0)
                komut.Parameters.AddWithValue("@Emlak_Id", Emlak_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
                if (Emlak_Id <= 0)
                {
                    komut.CommandText = "select @@IDENTITY as sonuc order by sonuc desc";
                    SqlDataReader dr = komut.ExecuteReader();
                    dr.Read();
                    sonuc = Convert.ToInt32(dr["sonuc"]);
                    dr.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            baglan.Close();
            baglan.Dispose();
            komut.Dispose();
            return sonuc;
        }
        public int IslemIptal(int Emlak_Id)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglan;
            komut.CommandText = "delete from Kayitlar where Emlak_Id=@Emlak_Id";
            komut.Parameters.AddWithValue("@Emlak_Id", Emlak_Id);
            komut2.CommandText = "UPDATE Ilanlar set Aktif_Pasif=1 where Emlak_Id=@Emlak_Id";
            komut2.Parameters.AddWithValue("@Emlak_Id", Emlak_Id);
            int sonuc1 = 0, sonuc2 = 0, sonuc = 0;
            try
            {
                baglan.Open();
                sonuc1 = komut.ExecuteNonQuery();
                sonuc2 = komut2.ExecuteNonQuery();
                if (sonuc1 == 1 && sonuc2 == 1)
                    sonuc = 1;
            }
            catch (Exception)
            {
                throw;
            }
            baglan.Close();
            komut.Dispose();
            komut2.Dispose();
            return sonuc;
        }
        public int IlanIptal(int Emlak_Id)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "delete from Ilanlar where Emlak_Id=@Emlak_Id";
            komut.Parameters.AddWithValue("@Emlak_Id", Emlak_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            baglan.Close();
            komut.Dispose();
            return sonuc;
        }
        public int MusteriIptal(int Musteri_Id)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            komut.CommandText = "delete from Musteriler where Musteri_Id=@Musteri_Id";
            komut.Parameters.AddWithValue("@Musteri_Id", Musteri_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            baglan.Close();
            komut.Dispose();
            return sonuc;
        }
        public int Ozellikler(int Ozellik_Id, int Ev_Metre, int Oda_Sayi_Id, int Banyo_Sayisi, int Bina_Yas_Id, int Bulundugu_Kat, int Isitma_Id, bool Ev_Esya)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            if (Ozellik_Id > 0)
                komut.CommandText = "update Ozellikler set Ev_Metre=@Ev_Metre, Oda_Sayi_Id=@Oda_Sayi_Id, Banyo_Sayisi=@Banyo_Sayisi, Bina_Yas_Id=@Bina_Yas_Id, Bulundugu_Kat=@Bulundugu_Kat, Isitma_Id=@Isitma_Id, Ev_Esya=@Ev_Esya where Ozellik_Id=@Ozellik_Id";
            else
                komut.CommandText = "insert into Ozellikler(Ev_Metre, Oda_Sayi_Id, Banyo_Sayisi, Bina_Yas_Id, Bulundugu_Kat,Isitma_Id,Ev_Esya) values (@Ev_Metre, @Oda_Sayi_Id, @Banyo_Sayisi, @Bina_Yas_Id, @Bulundugu_Kat,@Isitma_Id,@Ev_Esya)";
            komut.Parameters.AddWithValue("@Ev_Metre", Ev_Metre);
            komut.Parameters.AddWithValue("@Oda_Sayi_Id", Oda_Sayi_Id);
            komut.Parameters.AddWithValue("@Banyo_Sayisi", Banyo_Sayisi);
            komut.Parameters.AddWithValue("@Bina_Yas_Id", Bina_Yas_Id);
            komut.Parameters.AddWithValue("@Bulundugu_Kat", Bulundugu_Kat);
            komut.Parameters.AddWithValue("@Isitma_Id", Isitma_Id);
            komut.Parameters.AddWithValue("@Ev_Esya", Ev_Esya);
            if (Ozellik_Id > 0)
                komut.Parameters.AddWithValue("@Ozellik_Id", Ozellik_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
                if (Ozellik_Id <= 0)
                {
                    komut.CommandText = "select @@IDENTITY as sonuc order by sonuc desc";
                    SqlDataReader dr = komut.ExecuteReader();
                    dr.Read();
                    sonuc = Convert.ToInt32(dr["sonuc"]);
                    dr.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            baglan.Close();
            baglan.Dispose();
            komut.Dispose();
            return sonuc;
        }
        public int Adres(int Adres_Id, string Acik_Adres, int Mahalle_Id)

        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            if (Adres_Id > 0)
                komut.CommandText = "update Adres set Acik_Adres=@Acik_Adres, Mahalle_Id=@Mahalle_Id  where Adres_Id=@Adres_Id";
            else
                komut.CommandText = "insert into Adres(Acik_Adres,Mahalle_Id) values (@Acik_Adres,@Mahalle_Id)";
            komut.Parameters.AddWithValue("@Acik_Adres", Acik_Adres);
            komut.Parameters.AddWithValue("@Mahalle_Id", Mahalle_Id);

            if (Adres_Id > 0)
                komut.Parameters.AddWithValue("@Adres_Id", Adres_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
                if (Adres_Id <= 0)
                {
                    komut.CommandText = "select @@IDENTITY as sonuc order by sonuc desc";
                    SqlDataReader dr = komut.ExecuteReader();
                    dr.Read();
                    sonuc = Convert.ToInt32(dr["sonuc"]);
                    dr.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            baglan.Close();
            baglan.Dispose();
            komut.Dispose();
            return sonuc;
        }
        public int Diger_Ozellikler(int Diger_Id, bool D_Otopark, bool D_Asansor, bool D_Guvenlik, bool D_Havuz, bool D_Alarm)

        {
            SqlConnection baglan = this.baglan();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglan;
            if (Diger_Id > 0)
                komut.CommandText = "update Diger_Ozellikler set D_Otopark=@D_Otopark,D_Asansor=@D_Asansor,D_Guvenlik=@D_Guvenlik,D_Havuz=@D_Havuz,D_Alarm=@D_Alarm  where Diger_Id=@Diger_Id";
            else
                komut.CommandText = "insert into Diger_Ozellikler(D_Otopark,D_Asansor,D_Guvenlik,D_Havuz,D_Alarm) values (@D_Otopark,@D_Asansor,@D_Guvenlik,@D_Havuz,@D_Alarm)";
            komut.Parameters.AddWithValue("@D_Otopark", D_Otopark);
            komut.Parameters.AddWithValue("@D_Asansor", D_Asansor);
            komut.Parameters.AddWithValue("@D_Guvenlik", D_Guvenlik);
            komut.Parameters.AddWithValue("@D_Havuz", D_Havuz);
            komut.Parameters.AddWithValue("@D_Alarm", D_Alarm);
            if (Diger_Id > 0)
                komut.Parameters.AddWithValue("@Diger_Id", Diger_Id);
            int sonuc = 0;
            try
            {
                baglan.Open();
                sonuc = komut.ExecuteNonQuery();
                if (Diger_Id <= 0)
                {
                    komut.CommandText = "select @@IDENTITY as sonuc order by sonuc desc";
                    SqlDataReader dr = komut.ExecuteReader();
                    dr.Read();
                    sonuc = Convert.ToInt32(dr["sonuc"]);
                    dr.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            baglan.Close();
            baglan.Dispose();
            komut.Dispose();
            return sonuc;
        }


    }
}

