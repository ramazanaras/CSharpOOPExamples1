using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win11_generic
{
   // class Ogrenci<Temsili>

    //dşarıdan birden fazla tip alabilir.
    class Ogrenci<T,H,Y>  where T:class where H:struct  //T elemanı class tipinde  olmak zorundadır dedik ve H elemanıda struct tipinde olmalıdır.
    {
        /*Generic:
         Dışarıdan bir tip alarak çalışmayı sağlayan bir yapıdır.
         * 
         
         */
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Y OkulNo { get; set; }  //Y tipinde(dışardan gelen tip)
        public H Okulu { get; set; }   //H tipinde(dışardan gelen tip)
        public T TemsiliTip { get; set; } //T tipinde(dışardan gelen tip)
      //  public Temsili TemsiliTipi { get; set; }  //Temsili tipinde  dışardan gelen tipe göre değişiyor.


        public void Ekle(T prm) { 
        
        
        }

    }
}
