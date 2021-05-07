using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova
{
    class CEO : AbstractHandler
    {
        public override LivelloApprovazione Handle(int importo)
        {
            if (importo <= 2500)
                return LivelloApprovazione.CEO;
            else
                return base.Handle(importo);
        }

    }
}
