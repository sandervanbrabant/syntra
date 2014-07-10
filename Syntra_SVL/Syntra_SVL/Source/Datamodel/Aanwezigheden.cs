using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Aanwezigheden
    {
        public Aanwezigheden()
        {
        }

        public string externe_referentie { get; set; }
        public string lesmoment { get; set; }
        public string persoon { get; set; }
        public string aanwezigheids_code { get; set; }
        public Link links { get; set; }

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(lesmoment, "lesmoment");
            sJson += setJson(persoon, "persoon");
            sJson += setJson(aanwezigheids_code, "aanwezigheids_code");
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
