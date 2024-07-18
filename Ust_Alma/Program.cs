using System;

namespace Ust_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = Convert.ToDouble(Console.ReadLine());
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}^{1}={2}",s1,s2,Matematik.UstAlma(s1,s2));  // s1 s2 sayılarını girerek üstlerini alabilirsin.
        }
    }
}
