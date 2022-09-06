using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = (" Yazılım Gelişitirici Yetiştirme Kampı ");
            string kurs2 = ("Programlamaya Başlangıç için Temel Kurs");
            string kurs3 = ("Java");
            string kurs4 = ("Python");

            //array = dizi liste  çok daha dinamik kod yazmaya yarar.Aşağıda örnek var.

            string[] kurslar = new string[] {"C#","Python" ,"Yazılım Gelişitirici Yetiştirme Kampı " , "Programlamaya Başlangıç için Temel Kurs" , "Java"};



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");

            //Foreach dizilere uygulanır. Bu kodla her bir elemana kurs adını takıyor ve sıralıyor.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");
        }



    }






}