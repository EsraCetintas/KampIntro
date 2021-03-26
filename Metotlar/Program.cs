using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();

            urun1.Ad = "karpuz";
            urun1.Fiyat = 70;
            urun1.Aciklama = "diyarbakır karpuzu";

            urun2.Ad = "elma";
            urun2.Fiyat = 20;
            urun2.Aciklama = "amasya elması";

            urun3.Ad = "portakal";
            urun3.Fiyat = 50;
            urun3.Aciklama = "washington portakalı";

            Sepet sepet = new Sepet();
            sepet.Ekle(urun1);
        }
    }
}
