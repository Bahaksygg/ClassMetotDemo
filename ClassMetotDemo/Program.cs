using System;


namespace ClassMetotDemo
{
    class musteri
    {
        public string Adi { get; set; }
        public int Yas { get; set; }
        public int Id { get; set; }
        public int KrediPuani { get; set; }
        public string Meslek { get; set; }
    }

    class MusteriManager
    {
        public void Add(musteri Musteri)
        {
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("------------");
        }

        public void Listele(musteri[] Musteriler)
        {
            foreach (musteri musteri in Musteriler)
            {
                Console.WriteLine("Müşteri Adi:" + musteri.Adi);
                Console.WriteLine("Müşteri Yaşı:" + musteri.Yas);
                Console.WriteLine("Müşteri Kimlik No:" + musteri.Id);
                Console.WriteLine("Müşteri Kredi Puanı:" + musteri.KrediPuani);
                Console.WriteLine("Müşteri Mesleği" + musteri.Meslek);
            }
        }

        public void Sil(musteri musteri)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("Müşteri Silindi:");
        }



    }

    class Program
    {


        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();
            musteri musteri2 = new musteri();
            musteri[] musteriler = new musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            musteri1.Adi = "Baha";
            musteri1.Yas = 18;
            musteri1.Id = 1;
            musteri1.KrediPuani = 1000;
            musteri1.Meslek = "Öğrenci";

            musteri2.Adi = "Talha";
            musteri2.Yas = 29;
            musteri2.Id = 2;
            musteri2.KrediPuani = 1900;
            musteri2.Meslek = "İş Adamı";

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);

        }
    }

}