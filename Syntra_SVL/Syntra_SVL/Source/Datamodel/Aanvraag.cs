using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Aanvraag
    {
        public Aanvraag(){
        }

        public string externe_referentie { get; set; }
        public string cursus_jaar { get; set; }
        public string lesplaats_code { get; set; }
        public string module_versie_referentie { get; set; }
        public string start_datum { get; set; }
        public string locatie { get; set; }
        public string cursus_verantwoordelijke { get; set; }
        public string commentaar { get; set; }
        public string is_praktijksplitsing { get; set; }
        public string is_ingetrokken { get; set; }
        public int extra_kenmerk_id { get; set; }
        public int doelgroepen_beleid_id { get; set; }

        public string getAanvraagJson()
        {
            string sData = "";
            
            return "{\"payload\":{\"externe_referentie\":\"2014/2015|13555\"," + 
                    "\"start_datum\":\"2014-11-01\",\"cursus_jaar\":\"2014/2015\"," +
                    "\"cursus_verantwoordelijke\":\"Jan\",\"is_ingetrokken\":\"false\"," +
                    "\"extra_kenmerk_id\":" + 346 + ",\"doelgroepen_beleid_id\":" + 500 + "," +
                    "\"locatie\":\"Beenhouwerij Verkest\",\"commentaar\":\"Vegetarische bereidingen\"," +
                    "\"lesplaats_code\":\"09\",\"module_versie_referentie\":\"423724\",\"is_praktijksplitsing\":\"true\"}}";
        }
    }
}
