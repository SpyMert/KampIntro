﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    class Urun
    {
        //Property - özellik
        public int Id { get; set; } // Bir datayı diğerlerinden ayırt etmek için kullandığımız eşsiz değeri anlatır.
        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; } 



    }
}
