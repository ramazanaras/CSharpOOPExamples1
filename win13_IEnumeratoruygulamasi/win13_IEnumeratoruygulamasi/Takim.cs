using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win13_IEnumeratoruygulamasi
{
    class Takim
    {
        //ctor tab tab
        public Takim()//sınıf üretilirken o an işlem yapmak için kullanılır.
        {
            Oyuncular = new List<Oyuncu>();//Takım sınıfı new 'lendiği anda(Form1'de Takim tkm = new Takim();) Oyuncular listesinide new 'le
        }
        public string Adi { get; set; }
        public DateTime KurulusYili { get; set; }
        public string StadIsmi { get; set; }
        public List<Oyuncu> Oyuncular { get; set; } 
    }
}
