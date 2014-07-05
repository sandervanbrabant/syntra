using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syntra_SVL.Source.Contactgegevens;

namespace Syntra_SVL.Source.Personen
{
    class PersoonNew
    {
        public PersoonNew()
        {
        }

        public Persoon[] personen { get; set; }
        public ContactAlsLink linked { get; set; }
    }
}
