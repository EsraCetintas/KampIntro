using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager manager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234;
            musteri1.Ad = "Esra";
            musteri1.Soyad = "Çetintaş";
            musteri1.Mail = "esracetoo58@gmail.com";
            manager.MusteriEkle(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.Id = 123456;
            musteri2.Ad = "Samet";
            musteri2.Soyad = "Çetintaş";
            musteri2.Mail = "sametcetoo58@gmail.com";
            manager.MusteriEkle(musteri2);

            Console.WriteLine();
            manager.MusteriListele();

            Console.WriteLine();
            manager.MusteriSil(musteri2);

            Console.WriteLine();
            manager.MusteriListele();
            Console.ReadKey();

        }
    }
}
