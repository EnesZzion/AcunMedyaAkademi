using _28._02._2025_CM_Odev.Odev2Gerekenler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2025_CM_Odev.Odev2Gerekenler.Class
{
    public class Mudur : SirketCalisanlari,I_Maaslar
    {
        public double MaasDegeri()
        {
            return 60000.0;
        }
    }
}
