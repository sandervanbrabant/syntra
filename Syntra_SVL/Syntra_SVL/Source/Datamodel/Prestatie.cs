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

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie_lesgever, "externe_referentie_lesgever");
            sJson += setJson(werknemersnummer_lesgever, "werknemersnummer_lesgever");
            sJson += setJson(dimona_contract, "dimona_contract");
            sJson += setJson(aantal_uren_prestatie, "aantal_uren_prestatie");
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(aantal_lesuren, "aantal_lesuren");
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
