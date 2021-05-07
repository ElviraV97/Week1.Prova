using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova
{
    class OperationalManagerHandler : AbstractHandler
    {
        public override LivelloApprovazione Handle(int importo)
        {
            if (importo <= 1000)
                return LivelloApprovazione.OperationalManager;
            else
                return base.Handle(importo);
        }

    }
}
