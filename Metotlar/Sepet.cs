using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Sepet
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Ürün sepete eklendi: " + urun.Ad);
        }
    }
}
