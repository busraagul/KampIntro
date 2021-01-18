using System;

namespace ClassMetotDemo_
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.IdNumarasi = 2345;
            musteri1.AdSoyad = "Zeynep Gökçe";
            musteri1.MailAdresi = "zgg@xmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.IdNumarasi = 2688;
            musteri2.AdSoyad = "Hamza Günalp";
            musteri2.MailAdresi = "hgg@xmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.IdNumarasi = 2345;
            musteri3.AdSoyad = "Efe Çavga";
            musteri3.MailAdresi = "ec@xmail.com";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            
            Console.WriteLine("Musterileri Listele");
            musteriManager.MusteriListesi(musteriler);

            Console.WriteLine("Musteri Sil");
            musteriManager.MusteriSilme(musteri3);













        }  
    }
}
