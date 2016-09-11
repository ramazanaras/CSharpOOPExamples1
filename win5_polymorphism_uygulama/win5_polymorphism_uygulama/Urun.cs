using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win5_polymorphism_uygulama
{
    class Urun
    {
        public string Adi { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public virtual decimal KdvliFiyatHesapla() //virtual diyerek ezilebilir yaptık yani başka sınıflarda bunu ezip çalışma yapısını değştirebiliriz.(ekmek sınıfında farklı çalışssın,tekstil ürünü sınıfında farklı çalışssın dedik.)
        {
            return Fiyat + (Fiyat * 0.18m);//m decimal demek
        
        }
    }
}
