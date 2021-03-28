using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //Engin Demiroğ
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Engin";
            gercekMusteri.Soyadi = "Demiroğ";
            gercekMusteri.TcNo = "1234567890";

            //kodlama.io
            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234567890";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(gercekMusteri);
            musteriManager.Add(tuzelMusteri);
        }
    }
}
