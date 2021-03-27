using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.Ad + " eklendi...");
        }


        public void MusteriListele()
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " silindi");
            musteriler.Remove(musteri);

        }
    }
}
