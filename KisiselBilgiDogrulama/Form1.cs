using System.Reflection;

namespace KisiselBilgiDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
                // TextBox'lardaki metinleri alýp Ogrenci nesnesine ata
                var ogrenci = new Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Bolum = txtBolum.Text.Trim()
                };

                // Özellikleri sýrayla incele
                foreach (var ozellik in typeof(Ogrenci).GetProperties())
                {
                    // Özellikte KontrolAttribute var mý?
                    var zorunlu = ozellik.GetCustomAttribute<KontrolAttribute>();
                    if (zorunlu != null)
                    {
                        var deger = (string)ozellik.GetValue(ogrenci);
                        if (string.IsNullOrWhiteSpace(deger))
                        {
                            // Hata mesajýný göster ve fonksiyonu sonlandýr
                            MessageBox.Show(zorunlu.HataMesaji, "Hata");
                            return;
                        }
                    }
                }
                // Tüm kontroller saðlandýysa sonucu ekranda göster
                lblSonuc.Text = $"Ad: {ogrenci.Ad}  Soyad: {ogrenci.Soyad}  Bölüm: {ogrenci.Bolum}";
            
        }
    }
}
