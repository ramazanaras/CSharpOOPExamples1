using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win7_enumeration
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public Alan Alani { get; set; }  //Alan tipinde
        public Cinsiyet Cinsiyet { get; set; }  //Cinsiyet tipinde
    }
    /*
     string şeklinde enumların içerisine değer yazılmaz
     * enum içerisindeki seçenek bir kelimeden fazla olsa bile kelimeler arasında boşluk bırakılmaz
     Not:Enumlar kullanıcının seçeceği seçenekler için oluşturulan bir yapı değildir.
     * Programcının uygulamasını idame ettirmesi için kullandığı bir yapıdır.
     * 
     * Enum sınıfı içerisinde getName ve getNames isminde iki tane method vardır.
     * GetName:verilen enum seçeneğinin değerini dönderir.
     * Enum.GetName(typeof(Alan),ogr.Alani);
     * GetNames:geriye string dizisi dönderir.Geriye belirtilen enum tipinin içerisindeki tüm seçenekleri string olarak geri dönderir.
     * Enum.GetNames(typeof(Alan))
     * 
     */
    public enum Alan  //böyle dee yapabiliriz yada Cinsiyetteki gibi sınıf oalrak ta yapabiliriz.
    {
        Sayisal=10,  //index numarası 10 dır
        Sozel=20,     //index numarası  20dir . gibi index numarasını istediğimiz gibi yazabiliriz.
        EsitAgirlik=30,//Esit Agirlik yazılmaz(boşluk olmaz)  
        Dil=40   //içerideki elemanların index lerini değiştirebiliriz bu şekilde.
    }

}
