using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interface
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int YasamDegeri { get; set; }
        public Silah Silahi { get; set; }//Silah sınıfı tipinde Silahi nesnesi döndürecek.


        public string NisanAl() { 
        //nişan alma işlemleri yapılacak
            //silahi propertysi IYakinlastirilabilir interface'ini implemente almış ise yani o yeteneği kazanmış ise
            if (Silahi is IYakinlastirilabilir)
            {
                IYakinlastirilabilir iy = (IYakinlastirilabilir)Silahi;
             return   iy.Yakinlastir();
            }
            else
            {
                return "";
            }
        }
        public void Saldir() {
        
        //saldırma işlemleri yapılacak.
        }
    }
}
