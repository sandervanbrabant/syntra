using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Lesmoment
    {
        public Lesmoment()
        {
        }

        public string externe_referentie { get; set; }
        public string lesdag { get; set; }
        public string startuur { get; set; }
        public string er_is_een_examen { get; set; }
        public string aantal_uren_lesmoment { get; set; }
        public string vak_omschrijving { get; set; }
        public string lokaal { get; set; }
        public string onderwerp { get; set; }
        public Link links { get; set; }

        public string aantal_lesuren { get; set; }
    }
}
