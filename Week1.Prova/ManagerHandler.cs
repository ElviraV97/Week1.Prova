using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova
{
    class ManagerHandler : AbstractHandler
    {
        public override LivelloApprovazione Handle(int importo)
        {
            if(importo <= 400)
                return LivelloApprovazione.Manager;
            else
                return base.Handle(importo);
        }
         
    }
}
