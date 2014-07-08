using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Jurylid
    {
        public Jurylid()
        {
        }

        public string voornaam { get; set; }
        public string familienaam { get; set; }
        public string externe_referentie { get; set; }
        public Link links { get; set; }
    }
}
