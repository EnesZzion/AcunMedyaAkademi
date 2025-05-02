🧩 Custom Attribute Ödevi - Windows Forms ile Kişisel Bilgi Doğrulama

🎯 Ödevin Amacı: Öğrenci bilgilerini alırken kendi yazdığın bir Custom Attribute kullanarak doğrulama işlemi yapman beklenmektedir.

✅ Yapılacaklar

1️⃣ Windows Forms projesi oluştur

Visual Studio kullanarak yeni bir Windows Forms App projesi aç.
Projeye anlamlı bir isim ver.
2️⃣ Form arayüzünü hazırla

3 adet TextBox ekle:
Öğrenci Adı
Öğrenci Soyadı
Öğrenci Bölümü
1 adet Buton ekle:
Bilgileri Doğrula
Her TextBox için açıklayıcı bir Label ekle.
Öğrencinin girilen bilgilerini bir label ile ekrana yazdır
3️⃣ Custom Attribute oluştur

Girişlerin boş geçilip geçilmediğini kontrol eden özel bir Attribute yaz.
Attribute içinde hata mesajı tanımlanabilmeli.
4️⃣ Öğrenci bilgilerini temsil eden bir sınıf oluştur

İsim, Soyisim ve Bölüm adında 3 özellik barındırsın.
Bu özelliklere kendi oluşturduğun Attribute'u ekle.
5️⃣ Buton tıklama olayında kontrol işlemini gerçekleştir

Attribute'lar üzerinden alınan bilgilerle girilen verilerin boş olup olmadığını kontrol et.
Eğer herhangi bir alan boşsa, Attribute’ta tanımlı olan hata mesajını kullanıcıya göster.
