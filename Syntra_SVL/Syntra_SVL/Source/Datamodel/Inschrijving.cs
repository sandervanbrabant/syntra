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

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(inschrijvingsdatum, "inschrijvingsdatum");
            sJson += setJson(uitschrijvingsdatum, "uitschrijvingsdatum");
            sJson += setJson(stage_overeenkomst, "stage_overeenkomst");
            sJson += setJson(leersecretaris_code, "leersecretaris_code");
            sJson += setJson(contract_nummer, "contract_nummer");
            sJson += setJson(opleiding_in_eigen_naam, "opleiding_in_eigen_naam");
            sJson += setJson(betaald_met_opleidingscheques, "betaald_met_opleidingscheques");
            sJson += setJson(educatief_verlof, "educatief_verlof");
            sJson += setJson(motivatie_bijberoep, "motivatie_bijberoep");
            sJson += setJson(request_hash, "request_hash");
            sJson += setJson(identity_hash, "identity_hash");
            if (links != null)
            {
                sJson += "\"links\":" + links.getJson() + ",";
            }
            if (sJson.Length == 1)
            {
                return "{}";
            }
            else
            {
                return sJson.Substring(0, sJson.Length - 1) + "}";
            }
        }

        private string setJson(string atribute, string atributeName)
        {
            if (atribute != null)
            {
                return "\"" + atributeName + "\":\"" + atribute + "\",";
            }
            else
            {
                return "";
            }
        }
    }
}
