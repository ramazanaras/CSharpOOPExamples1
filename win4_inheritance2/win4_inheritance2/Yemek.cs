using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win4_inheritance2
{
    class Yemek
    {
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public int AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }


        ////et yemekleri sınıfında başka çalışşın yemek sınfıında başka çalışmasını istiyorsak bunu polymorphism ile yapıcaz.
       public string SunumSekli()  
        {
            return "Yanında az pilav ve salata ile";
        } 
    
    
    }
}
