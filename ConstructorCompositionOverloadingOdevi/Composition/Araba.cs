using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCompositionOverloadingOdevi.Composition
{
    // Araba sınıfı, bileşenleri içeriyor
    class Araba
    {
        public Marka marka;
        public string model;
        public Kasa kasa;
        public Kapi kapi;
        public Pencere pencere;
        public double fiyat;

        public Araba(Marka marka, string model, Kasa kasa, Kapi kapi, Pencere pencere, double fiyat)
        {
            this.marka = marka;
            this.model = model;
            this.kasa = kasa;
            this.kapi = kapi;
            this.pencere = pencere;
            this.fiyat = fiyat;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine("Arabanın markası " + marka.ad + ", modeli " + model +
                              ", kapı sayısı " + kapi.kapiSayisi +
                              ", pencere sayısı " + pencere.pencereSayisi +
                              ", kasası " + kasa.tip +
                              ", fiyatı " + fiyat.ToString("N0") + " TL’dir.");
        }
    }

}
