namespace WindowsFormUygulamasıileArabaBilgiFormu_CM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        // "Görüntüle" butonuna tıklandığında çalışacak olay
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği bilgileri al
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;

            // Pencere ve kapı sayılarını sayısal olarak al
            int pencereSayisi = Convert.ToInt32(TxtPencere.Text);
            int kapiSayisi = Convert.ToInt32(txtKapi.Text);

            // Tüm bilgileri kullanıcıya mesaj kutusunda göster
            MessageBox.Show("Marka: " + marka + "\nModel: " + model + "\nRenk: " + renk +
                            "\nPencere Sayısı: " + pencereSayisi + "\nKapı Sayısı: " + kapiSayisi);
        }
    }
}

