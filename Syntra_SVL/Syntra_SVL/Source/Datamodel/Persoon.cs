using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Persoon
    {
        public Persoon()
        {
        }

        public string externe_referentie { get; set; }
        public string rrn { get; set; }
        public string familienaam { get; set; }
        public string voornaam { get; set; }
        public string geboortedatum { get; set; }
        public string geboorteplaats { get; set; }
        public string geboorteland { get; set; }
        public string geslacht { get; set; }
        public string straatnaam { get; set; }
        public string huisnummer { get; set; }
        public string bus { get; set; }
        public string postcode { get; set; }
        public string gemeente { get; set; }
        public string land { get; set; }
        public string nationaliteit { get; set; }
        public string thuistaal_id { get; set; }
        public string thuistaal { get; set; }
        public string hoofdberoep { get; set; }
        public string wil_zelfstandige_worden { get; set; }
        public string behaalde_bedrijfsbeheer { get; set; }
        public string beroepskennis { get; set; }
        public string diploma_buitenland { get; set; }
        public string hoogste_opleidingsniveau_id { get; set; }
        public string sociaal_status_id { get; set; }
        public string sociaal_statuut { get; set; }
    }
}
