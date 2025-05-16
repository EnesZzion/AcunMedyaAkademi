using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaRandevuSistemi
{

    public partial class Form1 : Form
    {
        // Veritabanı işlemleri için yardımcı sınıfımızın bir örneği (instance)
        private DatabaseHelper dbYardimcisi;

        // Form1 sınıfının yapıcı metodu (constructor). Form oluşturulduğunda ilk çalışan metottur.
        public Form1()
        {
            InitializeComponent(); // Formun üzerindeki kontrolleri (buton, textbox vb.) başlatan metot. Bu metot Form1.Designer.cs dosyasındadır.
            dbYardimcisi = new DatabaseHelper(); // Veritabanı yardımcımızı oluşturuyoruz.
            this.Load += new System.EventHandler(this.Form1_Yuklenirken); // Form yüklendiğinde Form1_Yuklenirken metodunun çalışmasını sağlıyoruz.
        }

        // Form ilk yüklendiğinde çalışan olay (event) metodudur.
        private void Form1_Yuklenirken(object sender, EventArgs e)
        {
            BranslariYukle(); // Branşları ComboBox'a yükleyen metodu çağırıyoruz.
            SaatleriYukle();  // Randevu saatlerini ComboBox'a yükleyen metodu çağırıyoruz.

            // Doktorlar ComboBox'ını başlangıçta boş ve pasif hale getiriyoruz.
            cmbDoktorlar.Items.Clear();
            cmbDoktorlar.Text = "Önce Branş Seçiniz";
            cmbDoktorlar.Enabled = false;

            // Branş ComboBox'ında seçim değiştiğinde cmbBranslar_SecimDegistiginde metodunun çalışmasını sağlıyoruz.
            this.cmbBranslar.SelectedIndexChanged += new System.EventHandler(this.cmbBranslar_SecimDegistiginde);
            // "Randevu Oluştur" butonuna tıklandığında btnRandevuOlustur_Tiklandiginda metodunun çalışmasını sağlıyoruz.
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Tiklandiginda);
        }

        // Veritabanından branş bilgilerini çekip cmbBranslar ComboBox'ına yükler.
        private void BranslariYukle()
        {
            try // Hata yakalama bloğu
            {
                // Veritabanından tüm branşları ve Id'lerini çekiyoruz, BransAdi'na göre sıralıyoruz.
                DataTable dtBranslar = dbYardimcisi.ExecuteQuery("SELECT Id, BransAdi FROM Branslar ORDER BY BransAdi");
                cmbBranslar.DisplayMember = "BransAdi"; // ComboBox'ta görünecek olan sütun adı.
                cmbBranslar.ValueMember = "Id";         // ComboBox'ta arka planda tutulacak değerin sütun adı (Branş ID'si).
                cmbBranslar.DataSource = dtBranslar;    // ComboBox'ın veri kaynağını ayarlıyoruz.

                if (dtBranslar.Rows.Count > 0) // Eğer en az bir branş varsa
                {
                    cmbBranslar.SelectedIndex = -1; // Başlangıçta hiçbir branş seçili olmasın.
                    cmbBranslar.Text = "Branş Seçiniz"; // Kullanıcıya bilgi mesajı göster.
                }
                else // Hiç branş bulunamazsa
                {
                    cmbBranslar.Text = "Branş Bulunamadı";
                    cmbBranslar.Enabled = false; // Branş ComboBox'ını pasif yap.
                }
            }
            catch (Exception ex) // Veritabanı işlemi sırasında bir hata oluşursa
            {
                MessageBox.Show("Branşlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranslar.Text = "Yükleme Hatası";
                cmbBranslar.Enabled = false;
            }
        }

        // Branş ComboBox'ında bir seçim yapıldığında çalışan olay metodudur.
        private void cmbBranslar_SecimDegistiginde(object sender, EventArgs e)
        {
            // Eğer geçerli bir branş seçilmişse (SelectedValue null değil ve int tipindeyse)
            if (cmbBranslar.SelectedValue != null && cmbBranslar.SelectedValue is int)
            {
                int seciliBransId = (int)cmbBranslar.SelectedValue; // Seçilen branşın ID'sini al.
                DoktorlariYukle(seciliBransId); // Bu branşa ait doktorları yükle.
            }
            else // Geçerli bir branş seçilmemişse (örn: form ilk yüklendiğinde veya seçim kaldırıldığında)
            {
                cmbDoktorlar.DataSource = null; // Doktorlar ComboBox'ının veri kaynağını temizle.
                cmbDoktorlar.Items.Clear();     // İçindeki öğeleri temizle.
                cmbDoktorlar.Text = "Önce Branş Seçiniz";
                cmbDoktorlar.Enabled = false;   // Doktorlar ComboBox'ını pasif yap.
            }
        }

        // Belirtilen branş ID'sine sahip doktorları veritabanından çekip cmbDoktorlar ComboBox'ına yükler.
        private void DoktorlariYukle(int bransId)
        {
            try // Hata yakalama bloğu
            {
                // Veritabanından belirtilen BransID'ye sahip doktorların Id'lerini ve Ad Soyadlarını birleştirerek çekiyoruz.
                string query = "SELECT Id, (DoktorAdi + ' ' + DoktorSoyadi) AS DoktorTamAdi FROM Doktorlar WHERE BransID = @BransID ORDER BY DoktorAdi, DoktorSoyadi";
                SqlParameter[] parameters = { new SqlParameter("@BransID", bransId) }; // Sorguya parametre ekliyoruz (SQL Injection önlemi).
                DataTable dtDoktorlar = dbYardimcisi.ExecuteQuery(query, parameters);

                cmbDoktorlar.DisplayMember = "DoktorTamAdi"; // ComboBox'ta görünecek olan sütun adı.
                cmbDoktorlar.ValueMember = "Id";           // ComboBox'ta arka planda tutulacak değerin sütun adı (Doktor ID'si).
                cmbDoktorlar.DataSource = dtDoktorlar;      // ComboBox'ın veri kaynağını ayarlıyoruz.

                if (dtDoktorlar.Rows.Count > 0) // Eğer bu branşta en az bir doktor varsa
                {
                    cmbDoktorlar.SelectedIndex = -1; // Başlangıçta hiçbir doktor seçili olmasın.
                    cmbDoktorlar.Text = "Doktor Seçiniz";
                    cmbDoktorlar.Enabled = true;    // Doktorlar ComboBox'ını aktif yap.
                }
                else // Bu branşta doktor bulunamazsa
                {
                    cmbDoktorlar.Text = "Bu Branşta Doktor Yok";
                    cmbDoktorlar.Enabled = false;   // Doktorlar ComboBox'ını pasif yap.
                }
            }
            catch (Exception ex) // Veritabanı işlemi sırasında bir hata oluşursa
            {
                MessageBox.Show("Doktorlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbDoktorlar.Text = "Yükleme Hatası";
                cmbDoktorlar.Enabled = false;
            }
        }

        // cmbSaatler ComboBox'ına sabit randevu saatlerini (09:00 - 17:00 arası, 12:00 hariç) yükler.
        private void SaatleriYukle()
        {
            cmbSaatler.Items.Clear(); // Önce mevcut saatleri temizle.
            // Saat 09:00'dan 17:00'a kadar döngü oluştur (12:00 öğle arası olduğu için atlanacak).
            for (int hour = 9; hour <= 17; hour++)
            {
                if (hour == 12) continue; // Eğer saat 12 ise bu adımı atla, ComboBox'a ekleme.
                cmbSaatler.Items.Add(string.Format("{0:D2}:00", hour)); // Saati "HH:00" formatında ekle (örn: "09:00").
            }
            if (cmbSaatler.Items.Count > 0) // Eğer en az bir saat eklendiyse
            {
                cmbSaatler.SelectedIndex = 0; // İlk saati varsayılan olarak seçili yap.
            }
            else
            { // Hiç saat eklenemezse (bu normalde olmamalı)
                cmbSaatler.Text = "Saat Bulunamadı";
                cmbSaatler.Enabled = false;
            }
        }

        // "Randevu Oluştur" butonuna tıklandığında çalışan olay metodudur.
        private void btnRandevuOlustur_Tiklandiginda(object sender, EventArgs e)
        {
            // 1. Girdi Doğrulaması: Gerekli alanların seçili/dolu olup olmadığını kontrol et.
            if (cmbBranslar.SelectedValue == null || !(cmbBranslar.SelectedValue is int))
            {
                MessageBox.Show("Lütfen bir branş seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBranslar.Focus(); // Branş ComboBox'ına odaklan.
                return; // Metottan çık, işlemi durdur.
            }

            if (cmbDoktorlar.SelectedValue == null || !(cmbDoktorlar.SelectedValue is int))
            {
                MessageBox.Show("Lütfen bir doktor seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDoktorlar.Focus();
                return;
            }

            if (cmbSaatler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir saat seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSaatler.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHastaAdi.Text)) // Hasta adı boş veya sadece boşluk karakterlerinden mi oluşuyor?
            {
                MessageBox.Show("Lütfen hasta adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHastaAdi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHastaSoyadi.Text)) // Hasta soyadı boş veya sadece boşluk karakterlerinden mi oluşuyor?
            {
                MessageBox.Show("Lütfen hasta soyadını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHastaSoyadi.Focus();
                return;
            }

            // 2. Tarih ve Saat formatının birleştirilmesi
            DateTime secilenTarih = dtpTarih.Value.Date; // DateTimePicker'dan sadece tarih kısmını al (saat kısmı 00:00:00 olur).
            string secilenSaatStr = cmbSaatler.SelectedItem.ToString(); // Seçilen saati string olarak al (örn: "09:00").

            // String saati TimeSpan nesnesine çevir.
            if (!TimeSpan.TryParse(secilenSaatStr, out TimeSpan secilenSaat))
            {
                MessageBox.Show("Geçersiz saat formatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime randevuTarihSaati = secilenTarih.Add(secilenSaat); // Tarih ile saati birleştirerek tam randevu zamanını oluştur.

            // Geçmiş tarih kontrolü: Randevu tarihi şu anki zamandan önce mi?
            if (randevuTarihSaati < DateTime.Now)
            {
                MessageBox.Show("Geçmiş bir tarih veya saate randevu alamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTarih.Focus();
                return;
            }

            // 3. Veritabanında çakışma kontrolü: Aynı doktor, aynı tarih ve saatte başka bir randevu var mı?
            int doktorId = (int)cmbDoktorlar.SelectedValue; // Seçilen doktorun ID'si.
            // Randevular tablosunda ilgili doktor ve tarih/saat için kayıt sayısını getiren sorgu.
            string checkQuery = "SELECT COUNT(*) FROM Randevular WHERE DoktorID = @DoktorID AND Tarih = @Tarih";
            SqlParameter[] checkParams =
            {
                new SqlParameter("@DoktorID", doktorId),
                new SqlParameter("@Tarih", randevuTarihSaati)
            };

            try // Hata yakalama bloğu (veritabanı işlemleri için)
            {
                DataTable dtCheck = dbYardimcisi.ExecuteQuery(checkQuery, checkParams); // Çakışma kontrol sorgusunu çalıştır.
                // Eğer sorgu sonuç döndürdüyse, ilk satırın ilk sütunundaki değer (kayıt sayısı) 0'dan büyükse çakışma var demektir.
                if (dtCheck != null && dtCheck.Rows.Count > 0 && Convert.ToInt32(dtCheck.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Seçtiğiniz doktor için bu tarih ve saatte zaten bir randevu mevcut. Lütfen başka bir zaman seçiniz.", "Randevu Çakışması", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Metottan çık.
                }

                // 4. Randevuyu veritabanına kaydetme
                int bransId = (int)cmbBranslar.SelectedValue; // Seçilen branşın ID'si.
                string hastaAdi = txtHastaAdi.Text.Trim(); // Hasta adını al, başındaki/sonundaki boşlukları temizle.
                string hastaSoyadi = txtHastaSoyadi.Text.Trim(); // Hasta soyadını al, başındaki/sonundaki boşlukları temizle.

                // Randevuyu Randevular tablosuna ekleyen SQL INSERT sorgusu.
                string insertQuery = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) VALUES (@HastaAdi, @HastaSoyadi, @BransID, @DoktorID, @Tarih)";
                SqlParameter[] insertParams =
                {
                    new SqlParameter("@HastaAdi", hastaAdi),
                    new SqlParameter("@HastaSoyadi", hastaSoyadi),
                    new SqlParameter("@BransID", bransId),
                    new SqlParameter("@DoktorID", doktorId),
                    new SqlParameter("@Tarih", randevuTarihSaati)
                };

                int result = dbYardimcisi.ExecuteNonQuery(insertQuery, insertParams); // INSERT sorgusunu çalıştır. Etkilenen satır sayısını döndürür.

                // 5. Başarılı/Başarısız mesajı ve form temizleme
                if (result > 0) // Eğer en az bir satır etkilendiyse (yani kayıt başarılıysa)
                {
                    MessageBox.Show("Randevu başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu temizleyerek yeni bir randevu için hazır hale getir (isteğe bağlı).
                    cmbBranslar.SelectedIndex = -1;
                    cmbBranslar.Text = "Branş Seçiniz";
                    cmbDoktorlar.DataSource = null;
                    cmbDoktorlar.Items.Clear();
                    cmbDoktorlar.Text = "Önce Branş Seçiniz";
                    cmbDoktorlar.Enabled = false;
                    // dtpTarih.Value = DateTime.Now; // Tarihi bugüne sıfırlamak istenirse bu satır açılabilir.
                    // cmbSaatler.SelectedIndex = 0; // Saati ilk saate sıfırlamak istenirse bu satır açılabilir.
                    txtHastaAdi.Clear();
                    txtHastaSoyadi.Clear();
                }
                else // Kayıt başarısızsa (bu normalde ExecuteNonQuery > 0 kontrolü ile yakalanır, ama ek bir güvence)
                {
                    MessageBox.Show("Randevu oluşturulurken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) // Veritabanı işlemi sırasında bir hata oluşursa
            {
                MessageBox.Show("Randevu oluşturma sırasında bir hata oluştu: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {

        }
    }
}
