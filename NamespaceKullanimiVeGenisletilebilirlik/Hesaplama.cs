using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Namespace, C#’ta sınıfları, arayüzleri, yapılandırmaları ve diğer bileşenleri gruplamak için kullanılan bir yapıdır. 
//Büyük projelerde isim çakışmalarını önlemek ve kodun düzenli olmasını sağlamak için kullanılır.

//Hesaplama sınıfını farklı bir namespace içinde tanımlıyoruz
namespace Matematik
{
    public class Hesaplama
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

}
