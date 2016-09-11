﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interfaceuygulama
{
    class Futbolcu
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public float Kilo { get; set; }
        public int FormaNumara { get; set; }
        public string Takimi { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int Yas
        {
            get
            {
                int yas = DateTime.Now.Year - DogumTarihi.Year;
                return yas;
            }
        
        }
    }
}
