using System;

namespace KampIntro
{

    class Program
    {

        static void Main(string[]args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
          
            
            
            
            
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");  

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }




              Console.WriteLine(kategoriEtiketi);

            double sicaklik = 20;
            string mesaj;
            if(sicaklik >= 15)
            {
                mesaj = "Disarisi sicak!";
            }
            else
            {
                mesaj = "Disarisi soguk!";
            }
            Console.WriteLine(mesaj);

            mesaj = (sicaklik >= 15) ? "Disarisi sicak!" : "Disarisi soguk!";
            Console.WriteLine(mesaj);



            string isim = "";

            while (isim == "")
            {
                Console.Write("İsmini gir:");
                isim = Console.ReadLine();
            }
                

            Console.WriteLine("Merhaba" + isim);

            Console.ReadKey();

            
            
            
            
            
            
            
            Console.WriteLine("Bugün günlerden ne?");
            string gün = Console.ReadLine();

            switch (gün)
            {
                case "Pazartesi":
                    Console.WriteLine("Bugün Pazartesi");
                         break;
                case "Salı":
                    Console.WriteLine("Salı");
                         break;
                case "Çarşamba":
                    Console.WriteLine("Bugün Çarşamba");
                    break;
                case "Perşembe":
                    Console.WriteLine("Bugün Perşembe");
                    break;
                case "Cuma":
                    Console.WriteLine("Bugün Cuma");
                    break;
                case "Cumartesi":
                    Console.WriteLine("Bugün Cumartesi");
                    break;
                case "Pazar":
                    Console.WriteLine("Bugün Pazar");
                    break;
                default:
                    Console.WriteLine("Böyle bir gün yok Allah'ın salağa");
                    break;




            }


        }

    }





}
//type safety = tip güvenliği
//kategoriEtiketi kodu bir değer tutucu(alyas)(alias)
