using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicilerVeDegiskenlerİleCalisma
{
    public class User
    {
        private string adSoyad;
        private int yas;
        public string Email;
        public string GetAdSoyad()
        {
            return adSoyad;
        }
        public void SetAdSoyad(string _adSoyad)
        {
            adSoyad = _adSoyad;
        }
        public int GetYas()
        {
            return yas;
        }
        public void SetYas(int _yas)
        {
                yas = _yas;
        }
        public void BilgileriGoster()
        {
            Console.WriteLine("----- Kullanıcı Bilgileri -----");
            Console.WriteLine("Ad Soyad:"+adSoyad);
            Console.WriteLine("Yaş:"+yas);
            Console.WriteLine("Email:"+Email);
            Console.WriteLine("-----------------------------");
        }
    }
}
