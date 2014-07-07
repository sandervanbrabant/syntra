using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Bedrijven
{
    class Bedrijf
    {
        public Bedrijf()
        {
        }

        public string externe_referentie { get; set; }
        public string ondernemersnummer { get; set; }
        public string naam { get; set; }
        public string straatnaam { get; set; }
        public string huisnummer { get; set; }
        public string bus { get; set; }
        public string postcode { get; set; }
        public string gemeente { get; set; }
        public string land { get; set; }
        public string juridisch_statuut_id { get; set; }
        public string bedrijfs_grootte_id { get; set; }
        public string bedrijfs_sector { get; set; }
        public string bedrijfs_activiteit { get; set; }
    }
}
