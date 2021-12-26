using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiSurada
{
    class SiparisDetay : Siparis
    {
        public static double vergi { get; set; }
        public static double tutar { get; set; }
        public static double agirlik { get; set; } //sepetteki toplam ağırlık
        public double miktarFiyat { get; set; }
        public static double kargo { get; set; }

        public double SadeceUrunler()//calcSubTotal
        {
            miktarFiyat = MiktarFiyatı(Miktar);
            return tutar = MiktarFiyatı(Miktar) + VergiHesapla();
        }
        public double MiktarFiyatı(int miktar)//getPriceForQuantity
        {
            miktarFiyat = Fiyat * miktar;
            return miktarFiyat;                                                            
        }
        public double VergiHesapla()//calcTax
        {
            vergi = MiktarFiyatı(Miktar)*0.10;
            return vergi;
        }
        public double AgirlikHesapla(double Agirlik)//calcWeight
        {
            agirlik = Agirlik;
            return agirlik;
        }
        public double KargoHesapla(double Agirlik)
        {
            kargo = Agirlik * 0.05;
            return kargo;
        }
    }
}
