using System;

namespace ClassIntro
{
     class Program
     {

        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 14;

            Kurs kurs1=new Kurs();
            //Yeni kurs tanımladık. Kurs tipinde.
            kurs1.KursAdi = "C#"; //String olarak yazma sebebimiz class'ı yazarken KursAdi'nı stirng olarak gireceğimizi söylememizdi.
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 87;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 100;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Mert Yurdabak";
            kurs4.IzlenmeOrani = 100;
            //Her kurs kısaca bir değişken.




            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen)
            // Classlarımızı array olarak da tanımlayabiliriz ki bu daha dinamik olur.
            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3 , kurs4 };

            //"Kurs" veri tipinde kaydedilmiş ve "kurslar" arrayindeki "kurs1 , kurs2" olarak sıralanan değişkenleri sırasıyla hepsine kurs takma ismini kullanarak sırala.
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
                //kurs diye adlandırılan bütün değişkenlerin adını sonra araya bir adet iki nokta bırakarak eğitmenini göster.
            }
        }








     }
    //Kendi veri tutucumuzu yazıyoruz.
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
      // kendi veri türümüzün içine 3 adet özellik (property) ekledik.















}
