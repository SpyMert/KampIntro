using System;

namespace Metodlar
{
    class Program
    {


        static void Main(string[] args)
        {
            Urun urunmeyve1 = new Urun();
            urunmeyve1.Adi = "Elma";
            urunmeyve1.Fiyati = 15;
            urunmeyve1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urunmeyve1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }

            Console.WriteLine("---------Metodlar----------");

            SepetManager sepetManager = new SepetManager();
            //instance class örneği
            //encapsulation = kapsülleme düzensiz olacak bir şeyi düzene sokma
            sepetManager.Ekle(urunmeyve1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);

        }



    }





   







}
//Metodlar tekrar tekrar kullanılabilirliği sağlayan kod bloğudur.
//Do not repeat yourself - DRY - Clean Code - Best Practice