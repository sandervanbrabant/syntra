using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class LesmomentLink
    {
        public LesmomentLink()
        {
        }

        public Prestatie[] prestaties { get; set; }
        public Jurylid[] juryleden { get; set; }

        public string getJson()
        {
            string sJson = "\"linked\":{\"prestaties\":[";
            if (prestaties != null && prestaties.Length != 0)
            {
                for (int i = 0; i < prestaties.Length; i++)
                {
                    sJson += prestaties[i].getJson() + ",";
                }
                sJson = sJson.Substring(0, sJson.Length - 1);
            }
            sJson += "],\"juryleden\":[";
            if (juryleden != null && juryleden.Length != 0)
            {
                for (int j = 0; j < juryleden.Length; j++)
                {
                    sJson += juryleden[j].getJson() + ",";
                }
                sJson = sJson.Substring(0, sJson.Length - 1);
            }
            return sJson + "]}";
        }
    }
}
