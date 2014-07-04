using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Contactgegevens
{
    class ContactZonderLink
    {
        public ContactZonderLink()
        {
        }

        public string contact_type { get; set; }
        public string waarde { get; set; }
        public string externe_referentie { get; set; }
    }
}
