using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Link
    {
        public Link()
        {
        }

        public string persoon { get; set; }
        public string aanvraag { get; set; }
        public string cursist { get; set; }
        public string bedrijf { get; set; }
        public string module_vak { get; set; }
        public string lesmoment { get; set; }

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(persoon, "persoon");
            sJson += setJson(aanvraag, "aanvraag");
            sJson += setJson(cursist, "cursist");
            sJson += setJson(bedrijf, "bedrijf");
            sJson += setJson(module_vak, "module_vak");
            sJson += setJson(lesmoment, "lesmoment");
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
