using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win3_kapsulleme
{
    class Urun
    {
        //bir sınıf içerisinde tanımlanan değişkenlere field(alan) denir.
      //public  string Adi;
      //public void AdiYaz(string deger) {

      //    if (deger=="Admin")
      //    {
      //        Adi = deger;
      //    }
      //}
      //public string AdiOku() {
      //    if (true)
      //    {
      //        //geriye adi değerini döndürmeden bir işlem yapabiliriz.
      //    }
      //    return Adi;
      //}
      //public  string Soyadi;

        //--yukarıdakiler klasik yöntem


        
        //field
        private string _Adi; //asıl  değer tutan eleman.

        //property
        public string Adi 
        {
             get  //değer okunur.
            {
                //return _Adi; //değer okunuur

                if (_Adi=="Admin")
                {
                    return "Hoşgeldin Admin";
                }
                else
                {
                    return "Admin kullanıcısı değilsiniz oturumunuz açılmadı";
                }
                

            }
            set    //değer atanır
            {
                
                    _Adi = value;
               
                
            }
        }

        private decimal fiyat;//field

        public decimal Fiyat//property
        {
            get
            {
                return fiyat;
            }
            set
            {
                fiyat = value;
            }
        }

        private decimal _KdvliFiyat;//bunu yazmasakta olurdu çünkü set ile değer atamıyoruz.

        public decimal KvdliFiyat //sadece okunabilir oldu (get)
        {

            get
            {

                return Fiyat + (Fiyat * 0.18m);  //return fiyat+fiyat * 0.18m); küçük fiyat'ıda atabilirdik.ama genelde propety olanı yazıyoruz.
            
            }
        
        }



        /*
         *Auto property
         * arka plandaki fieldını kendi içerisinde tutar.
         * -ayrıca field tanımlanmaz
         * -get ve set metodları değiştirilemez.Değiştirilmek istenirse auto property bozulur.Arka plandaki fieldı elimizle tanımlamamız gerekir.
         * 
         */


       // public string Soyadi; //field


        //auto property(ayrıca field tanımlamamıza gerek kalmıyor)
        public string Soyadi { get; set; } //aşağıdakinin aynısı demek 



        //private string _Soyadi;

        //public string Soyadi { 
        //    get 
        //    {
        //        return _Soyadi;
        //    }
        //    set
        //    {
        //        _Soyadi = value;
        //    }
        //}
    }
}
