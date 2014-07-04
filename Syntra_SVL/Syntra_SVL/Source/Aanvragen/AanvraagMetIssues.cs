using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Aanvragen
{
    class AanvraagMetIssues
    {
        public AanvraagMetIssues()
        {
        }

        public string externe_referentie { get; set; }
        public string cursus_jaar { get; set; }
        public string lesplaats_code { get; set; }
        public string module_versie_referentie { get; set; }
        public string locatie { get; set; }
        public string cursus_verantwoordelijke { get; set; }
        public string commentaar { get; set; }
        public bool is_praktijksplitsing { get; set; }
        public bool is_ingetrokken { get; set; }
        public int extra_kenmerk_id { get; set; }
        public int doelgroepen_beleid_id { get; set; }
    }
}
