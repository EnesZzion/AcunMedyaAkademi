using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselBilgiDogrulama
{
    public class Ogrenci
    {
        [KontrolAttribute("Ad boş olamaz.")]
        public string Ad { get; set; }

        [KontrolAttribute("Soyad boş olamaz.")]
        public string Soyad { get; set; }

        [KontrolAttribute("Bölüm boş olamaz.")]
        public string Bolum { get; set; }
    }
}
