using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interface
{
    //kanas:dürbünlü silah
    class Kanas : AtesliSilahlar, IYakinlastirilabilir //Yakinlastir() metodunu implemente etmek zorundayım aşağıya.
    {

        public string Yakinlastir()
        {
            return "Yakınlaştırıldı";
        }
    }
}
