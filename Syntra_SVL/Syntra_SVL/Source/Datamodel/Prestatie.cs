using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Prestatie
    {
        public Prestatie()
        {
        }

        public string externe_referentie_lesgever { get; set; }
        public string werknemersnummer_lesgever { get; set; }
        public string dimona_contract { get; set; }
        public string aantal_uren_prestatie { get; set; }
        public string externe_referentie { get; set; }
        public Link links { get; set; }

        public string aantal_lesuren { get; set; }
    }
}
