using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interfaceuygulama
{
    class Muslera : Futbolcu, ITopTutabilable //yetenek kazandırıyoruz.
    {
        public string TopTut()
        {
            return "Top tutuldu";
        }
    }
}
