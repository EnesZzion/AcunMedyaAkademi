using _28._02._2025_CM_Odev.Odev1_3Gerekenler.Interface;
using _28._02._2025_CM_Odev.Odev1Gerekenler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2025_CM_Odev.Odev1Gerekenler.Class
{
    public class Porsche : Araba, I_ArabaOzellik3,I_HarcanilanBenzin
    {
        public double HarcanilanBenzinMiktari()
        {
            return 80.0;
        }
        public void Ucma(string isim)
        {
            Console.WriteLine(isim + "Havada Uçar");
        }
    }
}
