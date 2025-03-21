using ConstructorCompositionOverloadingOdevi;
using ConstructorCompositionOverloadingOdevi.Composition;
//------------------------------------------------Composition-------------------------------------------------------------//
// Bileşenleri oluşturuyoruz
Marka bmw = new Marka("BMW");
Kasa sedan = new Kasa("Sedan");
Kapi dortKapi = new Kapi(4);
Pencere dortPencere = new Pencere(4);

// Araba nesnesi oluşturuyoruz
Araba bmwX5 = new Araba(bmw, "X5", sedan, dortKapi, dortPencere, 2000000);

// Bilgileri ekrana yazdırıyoruz
bmwX5.BilgiYazdir();

//---------------------------------------------Method Overloading---------------------------------------------------------//

Matematik mat = new Matematik();

// Toplama işlemleri
Console.WriteLine("İkili Toplam Sonucu: " + mat.Topla(10, 5));

Console.WriteLine("Uclu Toplam Sonucu:" + mat.Topla(3, 7, 2));

// Çarpma işlemleri
Console.WriteLine("İnt Carpma Sonucu: " + mat.Carp(4, 5));
Console.WriteLine("Double Carpma Sonucu: " + mat.Carp(3.5, 2.2));