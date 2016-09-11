using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win9_abstract
{
    class Gitar:MuzikAletleri
    {
        public override string Cal()
        {
            return "Gitar çalınıyor";
        }
        
        public override CalmaTuru CalmaTuru//enum tipinde 
        {
            get
            {
                return CalmaTuru.TelliCalma;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
