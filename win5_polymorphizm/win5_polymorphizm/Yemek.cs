using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win5_polymorphizm
{
    class Yemek
    {
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public int AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }


        ////SunumSekli() metodu, et yemekleri sınıfında başka çalışşın yemek sınfıında başka çalışmasını istiyorsak bunu polymorphism ile yapıcaz.
       public virtual string SunumSekli()  //virtual koyarsak bu metod ezilebilir(override) olmuş olur.
        {
            return "Yanında az pilav ve salata ile";
        } 
    /*
     *virtual komutu ile işaretlenmiş metod isteğe bağlı olarak türetilen sınıflarda değiştirilebilir anlamına gelmektedir.Yani bu metot ezilebilir denilmiş olur.
     * 
     */
    
    }
}
