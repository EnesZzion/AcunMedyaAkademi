using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ConditionAssignment_CM.Odev2
{
    public class Araba
    {
        public string ArabaAd;
        public int ArabaYas;
        public double BenzinMiktari;
        public string ArabaSaglıkDurumu(int _yas)
        {
            switch (_yas)
            {
                case >= 0 and <= 10: return "Arabanız yeni";
                case > 10 and <= 20: return "Servise götürmeniz gerekebilir";
                case > 20 and <= 30: return "Arabanız hurdaya çıkabilir";
                default: return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
        }

    }
}
