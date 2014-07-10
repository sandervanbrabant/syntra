using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Jurylid
    {
        public Jurylid()
        {
        }

        public string voornaam { get; set; }
        public string familienaam { get; set; }
        public string externe_referentie { get; set; }
        public Link links { get; set; }

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(voornaam, "voornaam");
            sJson += setJson(familienaam, "familienaam");
            sJson += setJson(externe_referentie, "externe_referentie");
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
