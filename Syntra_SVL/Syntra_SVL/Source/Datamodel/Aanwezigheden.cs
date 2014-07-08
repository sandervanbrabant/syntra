using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Aanwezigheden
    {
        public Aanwezigheden()
        {
        }

        public string externe_referentie { get; set; }
        public string lesmoment { get; set; }
        public string persoon { get; set; }
        public string aanwezigheids_code { get; set; }
        public Link links { get; set; }
    }
}
