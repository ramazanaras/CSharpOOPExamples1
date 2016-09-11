using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win5_polymorphism_uygulama
{
    class Elektronik:Urun
    {
        public string Marka { get; set; }
        public string BataryaTipi { get; set; }

        //elektronik sınıfında kdvli fiyat hesapla fonsyionunun override etmedik çünkü kdv oranı 0.18 olduğu için urun sınıfındaki(base sınıfından(urun sınıfı)) metodu çalıştıracak.
    }
}
