using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemGiriş =true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("yok butonu");
            }
            else if (dolarDun < dolarBugun)
            {
               Console.WriteLine("yükselme butonu");
            }
            else
            {
                Console.WriteLine("değişim yok");
            }
        }
    }
}
