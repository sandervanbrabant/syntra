using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Link
    {
        public Link()
        {
        }

        public string persoon { get; set; }
        public string aanvraag { get; set; }
        public string cursist { get; set; }
        public string bedrijf { get; set; }
        public string module_vak { get; set; }
        public string lesmoment { get; set; }
    }
}
