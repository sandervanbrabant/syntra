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
        public string extra_kenmerk_id { get; set; }
        public string doelgroepen_beleid_id { get; set; }

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(cursus_jaar, "cursus_jaar");
            sJson += setJson(lesplaats_code, "lesplaats_code");
            sJson += setJson(module_versie_referentie, "module_versie_referentie");
            sJson += setJson(start_datum, "start_datum");
            sJson += setJson(locatie, "locatie");
            sJson += setJson(cursus_verantwoordelijke, "cursus_verantwoordelijke");
            sJson += setJson(commentaar, "commentaar");
            sJson += setJson(is_ingetrokken, "is_ingetrokken");
            sJson += setJson(is_praktijksplitsing, "is_praktijksplitsing");
            sJson += setJson(extra_kenmerk_id, "extra_kenmerk_id");
            sJson += setJson(doelgroepen_beleid_id, "doelgroepen_beleid_id");
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
