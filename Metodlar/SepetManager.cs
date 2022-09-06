using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager // Manager olmasının sebebi operasyon tutmasındandır.
    {
        //naming convention - isimlendirme kuralı
        public void Ekle(Urun urun)//Bir yerde parantez varsa demekki orada metod var. //Public void Python'da "def" idi.
        {//Urun  class
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
//Bir classın içinde birden fazla metod olabilir.