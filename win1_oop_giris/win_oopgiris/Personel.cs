using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_oopgiris
{
    class Personel  //referans tipli bir sınıf(turquaz renkli referans tipli oluyor)
    {
       internal string Adi;    //default private string Adi geliyor
       protected internal string Soyadi;//Form1 sınıfından erişilebiliyor.(Sadece protected yapsaydım Form1 sınıfından erişemezdim bu değişkene çünkü Form1 sınıfı Personel sınıfından miras almamış.)
        //protected DateTime DogumTarihi; //Form1 sınıfından bu değişkene ulaşılamıyor. //eğer mesela Personel sınıfı Personel 2 sınıfına miras verseydi Personel2 sınıfından  Doğum tarihine ulaşabilirdi.
       protected internal DateTime DogumTarihi;
        public string TCKN;
        /*
         * Access Modifiers -Erişim belirleyici 
         * Varsayılan erişim privatedir.Sadece bulunduğu yapı içerisinden erişilebilir.Başka yerden erişilemez.
         * 1-private :Kişisel anlamındadır.sadece bulunduğu yapı içerisinden erişilebilir.Başka yerden erişilemez.
         * 2-internal:Bulunduğu proje içerisinden her yerden erişimi sağlar.Farklı projeden erişime izin vermez(aynı solutiondaki yeni projede erişime kapalıdır.)
         * 3-protected:Miras alınan sınıflar içerisinden erişime izin verir.
         * 4-protected internal:Hem miras alınan sınflar içerisinden erişime izin verir hem de bulunduğu proje içerisinden her yerden erişilmesine izin verir.
         * 5-public:Umumi ,kamu malıdır.Her şekilde her yerden erişime izin verir
         * 
         */

        //bu şekilde yapmak yerine aşağıdaki gibide yapabiliriz
       //public void PersonelEkle(Personel p)//sınıf tipinde parametre gönderiyruz.
       // {
           
       //     //veritabanına personel ekleme işlemleri yapılır
       // }

        public void PersonelEkle() {
            string ad = Adi;
            string soyad=Soyadi;
        }        

    }
}
