using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win5_polymorphism_uygulama
{
    class Sepet
    {
        public decimal ToplamFiyat { get; set; }
       public void UrunEkle(Urun urn)
        {
            ToplamFiyat += urn.KdvliFiyatHesapla();
        
        }


    }
}
