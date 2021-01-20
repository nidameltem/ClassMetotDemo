using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Meltem";
            musteri1.Soyad = "Ağın";
            musteri1.Id = 152;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Eda";
            musteri2.Soyad = "Kaya";
            musteri2.Id = 153;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri must in musteriler)
            {
                Console.WriteLine(must.Ad);
                Console.WriteLine(must.Soyad);
                Console.WriteLine(must.Id);
                Console.WriteLine("**************************************");

            }
            Console.WriteLine("**************************************");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
