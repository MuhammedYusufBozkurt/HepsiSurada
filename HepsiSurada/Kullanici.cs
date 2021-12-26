using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HepsiSurada
{
    class Kullanici : Database
    {
        public Kullanici()
        {
            Baglan();
        }
        //KULLANICILAR İÇİN PROPERTY
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
        public int Telefon { get; set; }
        public string Adres { get; set; }
        public bool Yetki { get; set; }
        //***************************************
 
        public static int kulid = 0;
        public static string kulad = "";
        public static string kuladres = "";
        
        public void KullaniciDetay(int id)//Giriş yapan kullanıcının verilerini static değişkende tutuyoruz!!
        {
            cmd = new SqlCommand("SELECT Id, KullaniciAd, Adres FROM Kullanicilar WHERE Id='" + id + "'", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            while(oku.Read())
            { 
            kulid = Convert.ToInt32(oku[0]);
            kulad = oku[1].ToString();
            kuladres = oku[2].ToString();
            }
            conn.Close();
        }

        public List<Kullanici> Listele()//Kullanici sınıfı ile Aggregation ilişki bulunmakta
        {
            List<Kullanici> kullaniciListe = new List<Kullanici>();
            cmd = new SqlCommand("SELECT * FROM Kullanicilar", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                Kullanici k = new Kullanici();
                k.Id = Convert.ToInt32(oku[0]);
                k.Ad = oku[1].ToString();
                k.Soyad = oku[2].ToString();
                k.KullaniciAd = oku[3].ToString();
                k.Sifre = oku[4].ToString();
                k.Eposta = oku[5].ToString();
                k.Telefon = Convert.ToInt32(oku[6]);
                k.Adres = oku[7].ToString();
                k.Yetki = Convert.ToBoolean(oku[8]);
                kullaniciListe.Add(k);
            }
            conn.Close();
            return kullaniciListe;
        }
        public Kullanici girisKullanici(string kulad, string kulsif)//KULLANICI GİRİŞİ
        {
            Kullanici kul = null;
            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd='" + kulad + "' AND Sifre ='" + kulsif + "' ", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                kul = new Kullanici();
                kul.Id = int.Parse(oku[0].ToString());
                kul.KullaniciAd = oku[3].ToString();
                kul.Sifre = oku[4].ToString();
                kul.Yetki = Convert.ToBoolean(oku[8]);
            }
            conn.Close();
            return kul;
        }
        private bool kontrolKullanici(Kullanici kul)//KULLANICIYI KONTROL EDİYORUZ
        {
            bool result = false;
            cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd='" + kul.KullaniciAd + "' ", conn);
            conn.Open();
            var oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                result = true;
            }
            conn.Close();
            return result;
        }
        public bool ekleKullanici(Kullanici kul)//YENİ KULLANICI EKLEME
        {
            bool result = false;
            if (!kontrolKullanici(kul))
            {
                cmd = new SqlCommand("INSERT INTO Kullanicilar (Ad,Soyad,KullaniciAd,Sifre,Eposta,Telefon,Adres)" +
                    "VALUES ('" + kul.Ad + "', '" + kul.Soyad + "', '" + kul.KullaniciAd + "', '" + kul.Sifre + "', '" + kul.Eposta + "', '" + kul.Telefon + "', '" + kul.Adres + "')", conn);
                conn.Open();
                if (cmd.ExecuteNonQuery() != -1)
                {
                    result = true;
                }
                conn.Close();
            }
            return result;
        }
        public bool silKullanici(int id)//KULLANICI SİL
        {
            bool kontrol = false;
            cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE Id='" + id + "' AND Yetki=0", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontrol = true;
            }
            return kontrol;
        }
    }
}
