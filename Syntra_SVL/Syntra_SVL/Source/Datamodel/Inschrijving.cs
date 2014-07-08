using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Inschrijving
    {
        public Inschrijving()
        {
        }

        public string externe_referentie { get; set; }
        public string inschrijvingsdatum { get; set; }
        public string uitschrijvingsdatum { get; set; }
        public string stage_overeenkomst { get; set; }
        public string leersecretaris_code { get; set; }
        public string contract_nummer { get; set; }
        public string opleiding_in_eigen_naam { get; set; }
        public string betaald_met_opleidingscheques { get; set; }
        public string educatief_verlof { get; set; }
        public string motivatie_bijberoep { get; set; }
        public Link links { get; set; }
        public string request_hash { get; set; }
        public string identity_hash { get; set; }
    }
}
