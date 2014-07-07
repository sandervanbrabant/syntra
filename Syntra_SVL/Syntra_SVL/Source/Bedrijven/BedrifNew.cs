using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Bedrijven
{
    class BedrifNew
    {
        public BedrifNew()
        {
        }

        public Bedrijf[] bedrijven { get; set; }
        public Contactgegevens.ContactAlsLink linked { get; set; }
    }
}
