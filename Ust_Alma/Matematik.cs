using System;
using System.Collections.Generic;
using System.Text;

namespace Ust_Alma
{
    public class Matematik
    {
        /// <summary>
        /// Parametre olarak aldığı taban ve kuvvet bağlı olarak ustAlma işemi gerçekleştirir.
        /// </summary>
        /// <param name="taban">Taban</param>
        /// <param name="kuvvet">Kuvvet</param>
        /// <returns>Sonuç</returns>
        public static double UstAlma(double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <= kuvvet; i++)
                s *= taban;
            return s;
        }

      
    }
}
