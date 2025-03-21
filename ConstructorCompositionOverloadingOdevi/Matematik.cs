using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCompositionOverloadingOdevi
{
    public class Matematik
    {

        // İki tamsayıyı toplayan metod
        public int Topla(int a, int b)
        {
            return a + b;
        }

        // Üç tamsayıyı toplayan metod (Overload)
        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
       //------------------------------------------------------------------------
        // İki tamsayıyı çarpan metod
        public int Carp(int a, int b)
        {
            return a * b;
        }
        // İki double değeri çarpan metod (Overload)
        public double Carp(double a, double b)
        {
            return a * b;
        }

    }
}
