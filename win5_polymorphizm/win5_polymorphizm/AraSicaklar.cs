using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win5_polymorphizm
{
    class AraSicaklar:Yemek
    {
      //override yazıp boşluk bırakarak metodu görebiliriz.
        public override string SunumSekli()//yemek sınıfındaki metodu çalıştırma bizim yazdığımızı çalıştır.diyoruz.
        {
            //return base.SunumSekli(); eğer aşağıdakini yazmasaydık yemek sınıfındaki sunum şeklini çalıştırırdı.aşağıdakini yazarak metodu ezmiş olduk.bizim istediğimizi yazdık.
            return "yanında patetes kızartması ve içecek ile ";
        }
        /*
         * override:metodu ezmek anlamına geliyor.çalışma yapısını değiştirmemizi sağlıyor.
         */

    }
}
