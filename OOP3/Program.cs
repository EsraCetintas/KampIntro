using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new FileLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() 
            {
                ihtiyacKrediManager,
                konutKrediManager,
                tasitKrediManager
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
