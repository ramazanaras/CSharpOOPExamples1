using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win9_abstract
{
  abstract  class MuzikAletleri //abstract olarak tanımladık bu sınıftan instance alınmaz.
    {
        /*
         Abstract(soyut):
         * -Abstract sınıflar sadece miras verilmek için tasarlanan sınıflardır
         * -Abstract lar sınıfa özel değil bir property bir method veya herhangi bir eleman abstract olabilir.
         * Bir metodun abstract olması o metod miras verilen sınıflarda ezilmek zorundadır anlamına gelir.
         * Abstract metotların gövdesi olmaz.(içeriği yoktur.MuzikAletleri sınıfında)
         * Abstract metotlar abstract olmayan bir sınıfta bulunamaz.Sınıfta abstract olmalı
         * abstract sınıflar içerisindeki abstract olan property veya metotların gövdesi olmadığı için bu metotlara erişilmesin diye abstract sınıflardan instance üretilemez
         *Sınıf abstrackt olsada içerisinde abstract olmayan metot ve property bulunabilir.
         *-Ancak abstract bir metot veya bir property abstract olmayan sınıfta bulunamaz.
         *Abstrackt sınıfların genel amacı diğer sınıflara miras vermek içindir.Bu sınıftan instance alınıp kullanmayız.
         */

        //public virtual string Cal() {//ezilebilir dedik.
        //    return "Müzik aleti çalınıyor";
        //}

      //metotların gövdesi olmaz.
        public abstract string Cal();//ezilmek zorundadır dersek abstract kullanırız.yani miras verilen sınıflarda kullanılmak zorundadır.

      //propertylerinde gövdesi yok.
        public string Mensei { get; set; }//üretim yeri
        public DateTime UretimTarihi { get; set; }  //abstract sınıfta abstract olmayan şeyler kullanılabilir.

        public  abstract CalmaTuru CalmaTuru { get; set; } //enum tipinde 
      
    }
}
