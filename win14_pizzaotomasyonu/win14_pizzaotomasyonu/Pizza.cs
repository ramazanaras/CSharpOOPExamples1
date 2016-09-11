using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win14_pizzaotomasyonu
{
    class Pizza
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Ebat Ebati { get; set; }
        public KenarTip KenarTipi { get; set; }
        public List<string> Malzemeler { get; set; }


        public decimal Tutar
        {
            get  //geriye sonucu döndürüyor.
            {
                decimal tutar = 0;
                tutar = Fiyat * (decimal)Ebati.Carpan; //pizzanın ebatıyla çarptık
                tutar += KenarTipi.EkFiyat;   //kenar tipine göre ek fiyat ekledik
                return tutar;
            }
            
            
            }

        public override string ToString()
        {
            return Adi;  //pizzaların adını gösterdi.
        }
    }
}
