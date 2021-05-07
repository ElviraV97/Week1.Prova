using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        LivelloApprovazione Handle(int importo);
    }
}
