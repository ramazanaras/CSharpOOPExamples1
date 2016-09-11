using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win11_generic
{
    class MetotGeneric
    {
        //dışardan bir tip alır içerisinden de bu tipde eleman ister.
        public void Add<T>(T prm)   where T:struct //T elemanı struct olmalıdır.
        {
        
        
        }


    }
}
