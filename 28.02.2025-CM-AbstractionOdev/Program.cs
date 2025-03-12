using _28._02._2025_CM_Odev.Odev1Gerekenler.Class;
using _28._02._2025_CM_Odev.Odev2Gerekenler.Class;

///////////////////////////////////////////////////////////////ODEV-1////////////////////////////////////////////////////////////////
Bmw araba1 = new Bmw();
araba1.ArabaIsim = "Bmw ";
araba1.Ucma(araba1.ArabaIsim);
araba1.Yuzme(araba1.ArabaIsim);
araba1.Hız(araba1.ArabaIsim);


Mercedes araba2 = new Mercedes();
araba2.ArabaIsim = "Mercedes ";
araba2.Ucma(araba2.ArabaIsim);
araba2.Yuzme("Mercedes ");


Porsche araba3 = new Porsche();
araba3.ArabaIsim = "Porsche ";
araba3.Ucma(araba3.ArabaIsim);

//////////////////////////////////////////////////////////////ODEV-2//////////////////////////////////////////////////////////////

GenelMudur Calisan1= new GenelMudur();
Mudur Calisan2= new Mudur();
Programci Calisan3= new Programci();
Stajyer Calisan4= new Stajyer();


double toplamMaas = 0;
toplamMaas += Calisan1.MaasDegeri();
toplamMaas += Calisan2.MaasDegeri();
toplamMaas += Calisan3.MaasDegeri();
toplamMaas += Calisan4.MaasDegeri();

Console.WriteLine("Calisanların toplam maasi = " + toplamMaas);

//////////////////////////////////////////////////////////////ODEV-3//////////////////////////////////////////////////////////////

double toplamBenzin = 0.0;
toplamBenzin += araba1.HarcanilanBenzinMiktari();
toplamBenzin += araba2.HarcanilanBenzinMiktari();
toplamBenzin += araba3.HarcanilanBenzinMiktari();
Console.WriteLine("arabalarin 1 saatlik suruste harcadiklari toplam benzin miktari: " + toplamBenzin);



