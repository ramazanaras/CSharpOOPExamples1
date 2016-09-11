using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win10_interface
{
   public interface IYakinlastirilabilir
   { 
             /*
             sınıfa yetenek ve özellik kazandırır.bu sınıf yapabilir edebilir gibi özellikler kazandırır.
             * örneğin bir sınıfa sipariş edebilir,yemek yapabilir ,hesap alabilir interfacelerini verirsek bu sınıf bu özellikleri kazanır.
             * başka sınıflara rehber olmak için üretiriz interfaceleri.
             */

        /*İnterfaceler abstract classlara çok benziyor.
         * interfaceler başka sınıflar için yazılır.
         * Interface:
         * -interface içerisinde property,metot indexleyici ve event haricinde birşey bulunmaz.
         * -interface içerisindeki elemanların abstract sınıflarda olduğu gibi gövdesi bulunmaz.
         * Abstract sınıftan 1.farkı;gövdesi olan  bir metot veya propertyi yazamayız.
         * Abstract sınıftan 2.farkı:interface içerisindeki elemanların access modifers'ları bulunmaz.Ve varsayılan access modifiersları public'dir.(metotlara ve porpertylerin başına public yazmaya gerek yoktur.)
         * interface sınıfardan instance üretilemez.
         * Bir sınıf birden fazla interface 'i implemente edebilir.Yani barındırabilir.Ama bir sınıf bir sınıftan miras alır.
         * 
         */
      string Yakinlastir(); //gövdesi yok. Bu metodu implemente edilecek sınıflarda kullanmak zorundayız.Aynı abstract metot gibi implemente edilecek sınıflarda ezmek zorundayız.

    }
}
