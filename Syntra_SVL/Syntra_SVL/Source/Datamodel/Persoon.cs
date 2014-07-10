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

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(rrn, "rrn");
            sJson += setJson(familienaam, "familienaam");
            sJson += setJson(voornaam, "voornaam");
            sJson += setJson(geboortedatum, "geboortedatum");
            sJson += setJson(geboorteland, "geboorteland");
            sJson += setJson(geboorteplaats, "geboorteplaats");
            sJson += setJson(geslacht, "geslacht");
            sJson += setJson(straatnaam, "straatnaam");
            sJson += setJson(huisnummer, "huisnummer");
            sJson += setJson(bus, "bus");
            sJson += setJson(gemeente, "gemeente");
            sJson += setJson(postcode, "postcode");
            sJson += setJson(land, "land");
            sJson += setJson(nationaliteit, "nationaliteit");
            sJson += setJson(thuistaal_id, "thuistaal_id");
            sJson += setJson(thuistaal, "thuistaal");
            sJson += setJson(hoofdberoep, "hoofdberoep");
            sJson += setJson(wil_zelfstandige_worden, "wil_zelfstandige_worden");
            sJson += setJson(behaalde_bedrijfsbeheer, "behaalde_bedrijfsbeheer");
            sJson += setJson(beroepskennis, "beroepskennis");
            sJson += setJson(diploma_buitenland, "diploma_buitenland");
            sJson += setJson(hoogste_opleidingsniveau_id, "hoogste_opleidingsniveau_id");
            sJson += setJson(sociaal_statuut, "sociaal_statuut");
            sJson += setJson(sociaal_status_id, "sociaal_status_id");
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
