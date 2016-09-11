using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win8_static
{
    class Ogrenci
    {
        //ctor tab tab yazınca çıkar
        public Ogrenci()//constructor method(sınıf inşa edilirken(üretilme anında) kullanılır.)
        {
            TanimliOgrenciSayisi++;//=new Ogrenci() diyince bir artsın
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string Sinif { get; set; }
      //  public  int TanimliOgrenciSayisi { get; set; }  //=new Ogrenci() diyince bir artsın

        public static int TanimliOgrenciSayisi { get; set; }  //=new Ogrenci() diyince bir artsın
        //yukarıdaki elemana Form1.cs 'de o1.TanimliOgrenciSayisi diye ulaşamayız.
        //Ogrenci.TanimliOgrenciSayisi diye ulaşırız.
        //static yapınca artık TanimliOgrenciSayisi  o1 ve o2 den bağımsız olur ve Form1deki TanimliOgrenciSayisi 1 artıdığımızda hep 1 oluyordu   şimdi bir bir artırmış olacak.

        /*
         sınıftan instance almadan sınıfın sonuna nokta koyarak static elemana ulaşmamızı sağlar.
         * 
         */



        //static yapınca Ekle metodu o1 ve o2 nesnelerine özel olmuyor Ogrenci Sınıfına özel oluyor
        public static int  Ekle() { 
        
        //veritabanına öğrenci ekleme işlemi yapan metotdur.
            //static metotlar içerisinden static olmayan elemanlara ulamayız.
            //static metotlar içerisinde sadece static elemanlara ulaşılabilir.
            //TanimliOgrenciSayisi static olduğu için bu metot içerisinde buna ulaşılabilir sadece Adi,Soyadi değişkenlerine ulaşamayız
            return TanimliOgrenciSayisi;
        }


    }
}
