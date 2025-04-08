using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _​​​​​​​GenericListVENesneKullanimi
{
    public class Araba
    {
        public string Marka;
        public string Model;
        public double BenzinHarcamasi; // 100 km başına harcanan yakıt
        public double ToplamMesafe;  // Toplam mesafe

        public Araba(string marka, string model, double benzinHarcamasi, double toplamMesafe)
        {
            Marka = marka;
            Model = model;
            BenzinHarcamasi = benzinHarcamasi;
           ToplamMesafe = toplamMesafe;
        }

        public double ToplamBenzinHesapla()
        {
            return (ToplamMesafe / 100) * BenzinHarcamasi;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}");
            Console.WriteLine($"Toplam Mesafe: {ToplamMesafe} km");
            Console.WriteLine($"100 km'de Harcanan Yakıt: {BenzinHarcamasi} L");
            Console.WriteLine($"Toplam Harcanan Yakıt: {ToplamBenzinHesapla()} L\n");
        }
    }
}
