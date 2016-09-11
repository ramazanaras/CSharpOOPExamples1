using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win11_generic
{
    class Ders<T> where T:struct //bu tip struct olmalıdır.
    {
        public string Adi { get; set; }
        public int Kredi { get; set; }
    }
}
