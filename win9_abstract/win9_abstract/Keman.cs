using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win9_abstract
{
    class Keman : MuzikAletleri
    {
        public override string Cal()
        {
            throw new NotImplementedException();
        }

        public override CalmaTuru CalmaTuru
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
