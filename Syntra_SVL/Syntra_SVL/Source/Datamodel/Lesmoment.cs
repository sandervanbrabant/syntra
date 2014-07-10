using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Lesmoment
    {
        public Lesmoment()
        {
        }

        public string externe_referentie { get; set; }
        public string lesdag { get; set; }
        public string startuur { get; set; }
        public string er_is_een_examen { get; set; }
        public string aantal_uren_lesmoment { get; set; }
        public string vak_omschrijving { get; set; }
        public string lokaal { get; set; }
        public string onderwerp { get; set; }
        public Link links { get; set; }
        public string aantal_lesuren { get; set; }

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(lesdag, "lesdag");
            sJson += setJson(startuur, "startuur");
            sJson += setJson(er_is_een_examen, "er_is_een_examen");
            sJson += setJson(aantal_uren_lesmoment, "aantal_uren_lesmoment");
            sJson += setJson(vak_omschrijving, "vak_omschrijving");
            sJson += setJson(lokaal, "lokaal");
            sJson += setJson(onderwerp, "onderwerp");
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
