using _GenericListVENesneKullanimi;
// Üç farklı araba nesnesi oluşturuldu.
Araba araba1 = new Araba("Bmw", "X5", 9.0, 65);
Araba araba2 = new Araba("Mercedes", "C200", 8.2, 65);
Araba araba3 = new Araba("Toyota", "Corolla", 6.5, 65);

// Araba nesneleri listeye eklendi.
List<Araba> arabaListesi = new List<Araba>();
arabaListesi.Add(araba1);
arabaListesi.Add(araba2);
arabaListesi.Add(araba3);

foreach (var araba in arabaListesi)
 {
     araba.BilgiYazdir();
 }

