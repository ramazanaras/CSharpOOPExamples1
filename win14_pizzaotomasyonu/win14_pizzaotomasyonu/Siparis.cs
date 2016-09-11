using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win14_pizzaotomasyonu
{
    class Siparis
    {
        
        public Pizza Pizza { get; set; }   //Pizza tipinde 
        public int Adet { get; set; }
        

        public override string ToString()
        {
            string spr = "";
            spr += Pizza.Ebati.Adi + ",";
            spr += Pizza.Adi + ",";
            spr += Pizza.KenarTipi.Adi + ";";

            foreach (string mlz in Pizza.Malzemeler)
            {
                spr+=string.Format("{0},",mlz);
            }

            //sondaki virgülü kaldırmak için aşağıdaki kodu yazdık.
            spr = spr.Remove(spr.Length-1, 1);

            spr += string.Format(" {0}x{1}={2}", Adet, Pizza.Tutar, Adet * Pizza.Tutar);

            return spr;
        }
    }
}
