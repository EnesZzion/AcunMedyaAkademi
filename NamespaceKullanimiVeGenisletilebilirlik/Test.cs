using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matematik;
namespace NamespaceKullanimiVeGenisletilebilirlik
{
    public class Test
    {
         static void Main()
        {
            Hesaplama hesap = new Hesaplama();
            Console.WriteLine("Toplam: " + hesap.Topla(5, 7));
            Console.WriteLine("Çarpım: " + hesap.Carp(4, 6));
        }
    }
}
