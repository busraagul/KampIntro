using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo_
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni eklenen müsteri:"+ musteri.AdSoyad);
       
        }
        public void MusteriListesi(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("***************");
                Console.WriteLine("ID:" + musteri.IdNumarasi);
                Console.WriteLine("Ad Soyad" + musteri.AdSoyad);
                Console.WriteLine("E-mail:" + musteri.MailAdresi);
                Console.WriteLine("***************");

            }
        }
        public void MusteriSilme(Musteri musteri)
        {

            Console.WriteLine("silinen Musteri:" + musteri.AdSoyad);
        
        }
    }
}
