using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interfaceuygulama
{
    class ServetCetin:Futbolcu,ISavunabilable //yetenek kazandırıyoruz.
    {

        public string SavunmaYap()
        {
            return "Savunma yapıldı";
        }
    }
}
