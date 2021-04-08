using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var tip = typeof(DortIslem);
            //DortIslem ornek = (DortIslem)Activator.CreateInstance(tip);
            //Console.WriteLine(ornek.Topla(4,5));
            //var ornek = Activator.CreateInstance(tip, 4, 6);
            //MethodInfo methodInfo= ornek.GetType().GetMethod("Topla2");
            //Console.WriteLine(methodInfo.Invoke(ornek, null));

            var metodlar = tip.GetMethods();
            foreach (var metod in metodlar)
            {
                Console.WriteLine("Metod adı :" + metod);
            }

            Console.ReadKey();
        }
    }

    class DortIslem
    {
        int _sayi1;
        int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
    }
}

