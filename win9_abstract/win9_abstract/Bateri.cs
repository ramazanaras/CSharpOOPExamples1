using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win9_abstract
{
    class Bateri : MuzikAletleri
    {
        public override string Cal()
        {
            throw new NotImplementedException();
        }

        public override CalmaTuru CalmaTuru
        {
            get
            {
                return CalmaTuru.VurmaliCalma;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
