using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HepsiSurada
{
    class Urun : Database//ÖĞELER
    {
        public Urun()
        {
            Baglan();
        }

        //ÜRÜNLER İÇİN PROPERTY
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kategori { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
        public float Fiyat { get; set; }
        public float Agirlik { get; set; }
        //***************************
        public List<Urun> UrunDetay(int id)
        {
            List<Urun> urunListe = new List<Urun>();
            cmd = new SqlCommand("SELECT * FROM Urunler WHERE Id = '"+id+"'", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                Urun u = new Urun();
                u.Fiyat = Convert.ToSingle(oku["Fiyat"]);
                u.Agirlik = Convert.ToSingle(oku["Agirlik"]);
                urunListe.Add(u);
            }
            conn.Close();
            return urunListe;
        }

        public List<Urun> Listele()//Karışık bir şekilde listeliyoruz!
        {
            List<Urun> urunListe = new List<Urun>();
            cmd = new SqlCommand("SELECT * FROM Urunler", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                Urun u = new Urun();
                u.Id = Convert.ToInt32(oku["Id"]);
                u.Ad = oku["Ad"].ToString();
                u.Kategori = oku["Kategori"].ToString();
                u.Aciklama = oku["Aciklama"].ToString();
                u.Stok = Convert.ToInt32(oku["Stok"]);
                u.Fiyat = Convert.ToSingle(oku["Fiyat"]);
                u.Agirlik = Convert.ToSingle(oku["Agirlik"]);
                urunListe.Add(u);
            }
            conn.Close();
            return urunListe;
        }
        public List<Urun> KategoriListele(string kat)//Seçilen kategoriye göre listeleme
        {
            List<Urun> urunListe = new List<Urun>();
            cmd = new SqlCommand("SELECT * FROM Urunler WHERE Kategori = '" + kat + "' ", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())//Veritabanından gelen veriyi, property lere işliyoruz.
            {
                Urun u = new Urun();
                u.Id = Convert.ToInt32(oku["Id"]);
                u.Ad = oku["Ad"].ToString();
                u.Kategori = oku["Kategori"].ToString();
                u.Aciklama = oku["Aciklama"].ToString();
                u.Stok = Convert.ToInt32(oku["Stok"]);
                u.Fiyat = Convert.ToSingle(oku["Fiyat"]);
                u.Agirlik = Convert.ToSingle(oku["Agirlik"]);
                urunListe.Add(u);
            }

            conn.Close();
            return urunListe;
        }
        public string Ekle(Urun u)//Yeni ürün ekleme
        {
            int kontrol = 0;
            string durum = "";
            cmd = new SqlCommand("INSERT INTO Urunler (Ad, Kategori, Aciklama, Stok, Fiyat, Agirlik)  " +
            "VALUES ('" + u.Ad + "', '" + u.Kategori + "', '" + u.Aciklama + "', '" + u.Stok + "', '" + u.Fiyat + "', '" + u.Agirlik + "')", conn);
            conn.Open();

            kontrol = cmd.ExecuteNonQuery();
            if (kontrol == 1)
            {
                durum = "Ekleme işlemi başarılı.";
            }
            else
            {
                durum = "HATA";
            }

            conn.Close();
            return durum;
        }
        public bool Sil(int id)//Seçilen satırı silme
        {
            bool kontrol = false;
            cmd = new SqlCommand("DELETE FROM Urunler WHERE Id = '" + id + "'", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() != -1)
            {
                kontrol = true;
            }
            conn.Close();
            return kontrol;
        }
        public bool Guncelle(int id, Urun eskiUrun, Urun yeniUrun)//Seçilen satırı güncelleme
        {
            bool kontrol = false;
            cmd = new SqlCommand("UPDATE Urunler " +
                "SET Ad='" + yeniUrun.Ad + "', Kategori='" + yeniUrun.Kategori + "', Aciklama='" + yeniUrun.Aciklama + "', Stok='" + yeniUrun.Stok + "', Fiyat='" + yeniUrun.Fiyat + "', Agirlik='" + yeniUrun.Agirlik + "' WHERE Id = '" + id + "' ", conn);
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
