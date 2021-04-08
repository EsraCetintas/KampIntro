using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int> add = Topla;
            //Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate () 
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Console.WriteLine(getRandomNumber());
            Console.ReadKey();
        }

        public static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
    }

}
