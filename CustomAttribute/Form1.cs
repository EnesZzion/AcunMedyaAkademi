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
                // TextBox'lardaki metinleri al�p Ogrenci nesnesine ata
                var ogrenci = new Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Bolum = txtBolum.Text.Trim()
                };

                // �zellikleri s�rayla incele
                foreach (var ozellik in typeof(Ogrenci).GetProperties())
                {
                    // �zellikte KontrolAttribute var m�?
                    var zorunlu = ozellik.GetCustomAttribute<KontrolAttribute>();
                    if (zorunlu != null)
                    {
                        var deger = (string)ozellik.GetValue(ogrenci);
                        if (string.IsNullOrWhiteSpace(deger))
                        {
                            // Hata mesaj�n� g�ster ve fonksiyonu sonland�r
                            MessageBox.Show(zorunlu.HataMesaji, "Hata");
                            return;
                        }
                    }
                }
                // T�m kontroller sa�land�ysa sonucu ekranda g�ster
                lblSonuc.Text = $"Ad: {ogrenci.Ad}  Soyad: {ogrenci.Soyad}  B�l�m: {ogrenci.Bolum}";
            
        }
    }
}
