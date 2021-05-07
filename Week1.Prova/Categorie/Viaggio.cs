using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova.Categorie
{
    class Viaggio : ICategoria
    {
        public double Rimborso(int importo)
        {
            return (importo + 50);
        }
    }
}
