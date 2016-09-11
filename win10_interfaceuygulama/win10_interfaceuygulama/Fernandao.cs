using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interfaceuygulama
{
    class Fernandao:Futbolcu,ISutCekebilable  //aşağıdaki metodu implemente etttik.
    {
        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafe kadar şut çekildi",hiz,mesafe);
        }
    }
}
