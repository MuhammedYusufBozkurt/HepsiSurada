using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HepsiSurada
{
    class Siparis : Database
    {
        public Siparis()
        {
            Baglan();
        }
        //SİPARİŞ BİLGİLERİNİNİN PROPERTY LERİ
        public int Id { get; set; }
        public string KullaniciAd { get; set; }        
        public string Adres { get; set; }
        public string Urun { get; set; }
        public int Miktar { get; set; }
        public double Fiyat{ get; set; }
        public string Tutar{ get; set; }
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }

        //**************************************************
        public static string sepetUrun = "";
        public static int sepetId = 0;
        public static int sepetAdet = 0;
        public static double sepetTutar = 0;
        

        //SİPARİŞ TABLO İŞLEMLERİ
        public string SiparisEkle()
        {
            int kontrol = 0;
            string durum = "";

            string kulad = Kullanici.kulad;
            string kuladres = Kullanici.kuladres;
            string sepetUrunAdi = Siparis.sepetUrun;
            int sepetAdeti = Siparis.sepetAdet;
            string sepetTutar = Siparis.sepetTutar.ToString();

            cmd = new SqlCommand("INSERT INTO Siparisler (kullanici, adres, urun, miktar, tutar)" +
                "VALUES ('"+kulad+"', '"+kuladres+ "', '" + sepetUrunAdi + "', '" + sepetAdeti + "', '" + sepetTutar+ "')", conn);
            conn.Open();
            kontrol = cmd.ExecuteNonQuery();
            if (kontrol == 1)
            {
                cmd = new SqlCommand("UPDATE Urunler SET Stok= Stok - '"+Siparis.sepetAdet+"' " +
                    "WHERE Id='"+Siparis.sepetId+"'", conn);
                cmd.ExecuteNonQuery();
                durum = "SİPARİŞ BAŞARILI";
            }
            else
            {
                durum = "HATA";
            }

            conn.Close();
            return durum;
        }
        public List<Siparis> Listele()
        {
            List<Siparis> siparisler = new List<Siparis>();
            cmd = new SqlCommand("SELECT * FROM Siparisler", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                Siparis s = new Siparis();
                s.Id = int.Parse(oku["id"].ToString());
                s.KullaniciAd = oku["kullanici"].ToString();
                s.Adres = oku["adres"].ToString();
                s.Urun = oku["urun"].ToString();
                s.Miktar = int.Parse(oku["miktar"].ToString());
                s.Tutar = oku["tutar"].ToString();
                s.Tarih = Convert.ToDateTime(oku["tarih"].ToString());
                s.Durum = oku["durum"].ToString();
                siparisler.Add(s);
            }
            conn.Close();
            return siparisler;
        }
        public bool durumGuncelle(int secili, string durum)
        {
            bool kontrol = false;
            cmd = new SqlCommand("UPDATE Siparisler SET durum='" + durum + "' WHERE id='" + secili + "' ", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontrol = true;
            }

            conn.Close();
            return kontrol;
        }
    }
}
