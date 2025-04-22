 Reflection ile Ödeme Sistemi
🔹 Görev:
Bir Windows Forms hazırlayınız. Kullanıcıdan alınan tutar bilgisi ile seçilen ödeme yöntemi kullanılarak işlem yapılacaktır.

🎛️ Gerekli Kontroller:
ComboBox: Ödeme yöntemleri listelenecek.
TextBox: Tutar girilecek.
Button: Ödeme işlemini başlatacak.
Label: Sonuç gösterilecek.

📌 Kurallar:
IOdemeYontemi isminde bir interface oluşturunuz. string Ode(decimal tutar); metodunu içermelidir.
Bu interface’i implemente eden en az 3 farklı sınıf yazınız. Örn: KrediKarti, Havale, EFT
Form yüklendiğinde IOdemeYontemi arayüzünü implemente eden tüm sınıflar Reflection ile bulunarak ComboBox’a eklenecektir.

Kullanıcı seçim yapıp tutar girdikten sonra, butona basıldığında:
Seçilen sınıfın nesnesi Activator.CreateInstance(...) ile runtime’da oluşturulacaktır.
Ode() metodu çağrılacak ve sonuç Label üzerinde gösterilecektir.

🧪 Teslimat:
Tüm işlemler tek bir Windows Forms projesi içinde yapılacaktır.
Proje çalışır halde teslim edilmelidir.
Kod açıklamaları (yorum satırları) bulunmalıdır.
Arayüz sade, işlevsel ve kullanıcı dostu olmalıdır.
