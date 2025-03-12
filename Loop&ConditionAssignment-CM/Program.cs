using Loop_ConditionAssignment_CM.Odev1;
using Loop_ConditionAssignment_CM.Odev2;
using Loop_ConditionAssignment_CM.Odev2_Odev5;
using Loop_ConditionAssignment_CM.Odev4;
//-----------------------------------------------------Odev1-----------------------------------------------------------//
People Kisi1 = new People();
Kisi1.yas = 15;
Console.WriteLine(Kisi1.yas+ " Yaşındasınız: " + Kisi1.DurumHesapla(Kisi1.yas));

People Kisi2 = new People();
Kisi2.yas = 105;
Console.WriteLine(Kisi2.yas + " Yaşındasınız: " + Kisi2.DurumHesapla(Kisi2.yas));

//-----------------------------------------------------Odev2-----------------------------------------------------------//
Araba araba1 = new Araba();
araba1.ArabaAd = "Toyota";
araba1.ArabaYas = 12;
Console.WriteLine(araba1.ArabaAd + " " + araba1.ArabaYas + " Yasinda " + araba1.ArabaSaglıkDurumu(araba1.ArabaYas));
Araba araba2 = new Araba();
araba2.ArabaAd = "Audi";
araba2.ArabaYas = 5;
Console.WriteLine(araba2.ArabaAd + " " + araba2.ArabaYas + " Yasinda " + araba2.ArabaSaglıkDurumu(araba2.ArabaYas));

//-----------------------------------------------------Odev3-----------------------------------------------------------//
//do-While Kullanımı;Önce işlemi yapar, sonra koşulu kontrol eder. Koşul yanlış olsa bile en az bir kere çalışır.
int sayi2 = 0;
do
{
    Console.WriteLine("Do-While: " + sayi2);
    sayi2--;
} while (sayi2 > 0);

// While Kullanımı;Önce koşulu kontrol eder, sonra çalışır. Koşul baştan yanlışsa hiç çalışmaz.
int sayi1 = 0;
while (sayi1 > 0)
{
    Console.WriteLine("While: " + sayi1);
    sayi1--;
}
// Bu yüzden do-while da ekrana 0 yazdırabiliniyorken while da ekrana hiçbir şey yazdırılmaz.

//-----------------------------------------------------Odev4-----------------------------------------------------------//
Calisanlar calisan1= new Calisanlar();
calisan1.Ad = "Ali";
calisan1.Maas = 80000.0;
calisan1.Departman = "GM";
calisan1.Meslek = "GenelMüdür";

Calisanlar calisan2= new Calisanlar();
calisan2.Ad = "Mehmet";
calisan2.Maas = 60000.0;
calisan2.Departman = "MU";
calisan2.Meslek = "Mudur";

Calisanlar calisan3 = new Calisanlar();
calisan3.Ad = "Ahmet";
calisan3.Maas = 55000.0;
calisan3.Departman = "PR";
calisan3.Meslek = "Programci";

Calisanlar calisan4 = new Calisanlar();
calisan4.Ad = "Enes";
calisan4.Maas = 6000.0;
calisan4.Departman = "S";
calisan4.Meslek = "Stajyer";

Calisanlar[] CalisanKisiler =new Calisanlar[4];
CalisanKisiler[0]=calisan1;
CalisanKisiler[1]=calisan2;
CalisanKisiler[2]=calisan3;
CalisanKisiler[3]=calisan4;

double ToplamMaas = 0;
for (int i = 0; i < CalisanKisiler.Length; i++)
{
    ToplamMaas += CalisanKisiler[i].Maas;
    Console.WriteLine("Ad:"+CalisanKisiler[i].Ad+" Maas:"+CalisanKisiler[i].Maas+" Departman:"+ CalisanKisiler[i].Departman);
}
Console.WriteLine("Toplam Maas: "+ToplamMaas);
//-----------------------------------------------------Odev5-----------------------------------------------------------//
araba1.BenzinMiktari = 72.4;
araba2.BenzinMiktari = 34.7;

Araba araba3 = new Araba();
araba3.ArabaAd = "Bmw";
araba3.BenzinMiktari = 52.5;

Araba araba4= new Araba();
araba4.ArabaAd = "Togg";
araba4.BenzinMiktari = 12.3;

Araba[] arabalar = new Araba[4] {araba1,araba2,araba3,araba4};
double ToplamBenzinMiktari=0;
for(int i=0; i < arabalar.Length; i++)
{
    Console.WriteLine("Araba Adi:" + arabalar[i].ArabaAd +" Benzin Miktari:" + arabalar[i].BenzinMiktari);
    ToplamBenzinMiktari += arabalar[i].BenzinMiktari;
}
Console.WriteLine("ToplamBenzinMiktari: "+ToplamBenzinMiktari);