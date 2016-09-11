using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win5_polymorphismtoString
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string soyadi { get; set; }
        public string Tckn { get; set; }
        public DateTime DogumTarihi { get; set; }
       
        //tostring metodu polymorphisme güzel bir örnektir.

        //object sınıfındaki yani bu sınıfların base sınıfı olan object sınıfında ToString denen bir metot vardır ve bu metot sınıfın ismini döndürür.Virtual olduğu için biz bu metodu override edip ezebiliriz aşağıdaki gibi.

        public override string ToString()
        {
           return this.Adi + " " + this.soyadi + " " + this.Tckn + " " + this.DogumTarihi;
          //  return string.Format("{0}-{1}-{2}-{3}", Adi, soyadi, Tckn, DogumTarihi);

        }

       

    }
}
