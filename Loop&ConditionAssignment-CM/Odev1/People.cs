using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ConditionAssignment_CM.Odev1
{
    public class People
    {
        public int yas;
    
    public string DurumHesapla(int yas)
        {
            if(yas >= 0&&yas<=18) 
            {
                return "Kücüksünüz";
            }
            else if(yas > 18 && yas <= 35)
            {
                return "Gençsiniz";
            }
            else if(yas > 35 && yas <= 55)
            {
                return "Yetişkinsiniz";
            }
            else if(yas > 55 && yas <= 75)
            {
                return "Yaşlısınız";
            }
            else if (yas > 75 && yas <= 99)
            {
                return "Çok yaşlısınız";
            }
            else 
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            }
        }
    
    
    
    }
}
