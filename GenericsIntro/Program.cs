using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            Console.WriteLine(isimler.Count);
            isimler.Add("engin");
            Console.WriteLine(isimler.Count);
        } 
    }
}
