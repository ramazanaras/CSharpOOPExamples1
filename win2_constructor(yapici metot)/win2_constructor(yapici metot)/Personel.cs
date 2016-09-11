using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win2_constructor_yapici_metot_
{
    class Personel
    {
        //Constructor metottur.(Constructor metotlarının isimleri sınıfın ismiyle aynı olur)
       public Personel()//constructor metod(geriye birşey döndermez voidde yazmayız)
        {
            KayitTarihi = DateTime.Now;//sınıf üretilirken bu değişkene değer atanır.
        }
        //constructor metodunada overload yapabiliriz
       public Personel(string ad) {

           Adi = ad;
       
       }

       public Personel(string ad, string soyad,DateTime dt,string tckn)
       {

           Adi = ad;
           Soyadi = soyad;
           DogumTarihi = dt;
           TCKN = tckn;

       }

        internal string Adi;
        internal string Soyadi;
        public DateTime DogumTarihi;
        public string TCKN;

        public DateTime KayitTarihi;

        /*
         Constructor Metodu-Yapıcı Metod
         *-Nesnenin ramde üretilmesini sağlayan metottur.
         *Constructor metdou tanımlanmazsa varsayılan (default) constructor geçerlidir.
         * -Constructor metotlarının overloadı vardır.
         * Kendimiz sınıf içerisinde constructor metodu yazabiliriz.
         * Geriye dönüş tipi olmayan tek metotdur.
         * Sınıfa kendimiz constructor tanımlarsak varsayılan constructor iptal olur.
         * Sınıf içerisinde imzaları farklı olmak suretiyle birden fazla constructor tanımlayabiliriz.
         * Ve bu sınıftan örnek üretirken hangi constructora uyan değerler gönderildiyse o constructor çalışır.
         * Constructor metotlarının isimleri sınıfın ismiyle aynı olmak zorundadır.
         */


    }
}
