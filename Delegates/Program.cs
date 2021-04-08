using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int sayi1,int sayi2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();

            Console.WriteLine("---------");
            MyDelegate2 myDelegate2 = customerManager.ShowAlert2;
            myDelegate2("Selam");

            Console.WriteLine("---------");

            Matematik islem = new Matematik();
            MyDelegate3 myDelegate3 = islem.Topla;
            myDelegate3 += islem.Carp;
            Console.WriteLine(myDelegate3(3, 2));

            Console.ReadKey();
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Merhaba");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Dikkatli ol");
        }
        public void ShowAlert2(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
