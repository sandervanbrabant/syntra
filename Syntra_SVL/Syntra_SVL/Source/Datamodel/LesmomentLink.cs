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
    }
}
