using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselBilgiDogrulama
{
    public class KontrolAttribute:Attribute
    {
        public string HataMesaji { get; }
        public KontrolAttribute(string hataMesaji)
        {
            HataMesaji = hataMesaji;
        }
    }
}
