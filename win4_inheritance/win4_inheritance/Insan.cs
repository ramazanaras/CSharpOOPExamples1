using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win4_inheritance
{
    class Insan
    {
        //prop tab tab yazınca auto property  açar

        //propfull tab tab dersek fieldı olan propertyi oluştururur.
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }
        public DateTime DogumTarihi { get; set; }

    }
}
