using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova.Categorie
{
    class Vitto : ICategoria
    {
        public double Rimborso(int importo)
        {
            return (0.7 * importo);
        }
    }
}
