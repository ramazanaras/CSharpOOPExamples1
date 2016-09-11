using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interfaceuygulama
{
    class Hagi : Futbolcu, IOyunKurabilable, ISutCekebilable  //yetenek kazandırıyoruz.
    {

        public string OyunKur()
        {
            return "Oyun kuruldu";
        }

        public string CalimAt(float hiz)
        {
            return string.Format("{0} hızla çalım atıldı", hiz);
        }

        public string SutCek(float hiz, float mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafeye kadar şut çekildi",hiz,mesafe);
        }
    }
}
