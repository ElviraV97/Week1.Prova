using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Prova.Categorie
{
    public class CategorieFactory
    {
        public static ICategoria FactoryCategoria(string cat)
        {
            ICategoria categoria = null;
            if (cat.Equals("Viaggio"))
                categoria = new Viaggio();
            else if (cat.Equals("Alloggio"))
                categoria = new Alloggio();
            else if (cat.Equals("Vitto"))
                categoria = new Vitto();
            else if (cat.Equals("Altro"))
                categoria = new Altro();

            return categoria;
        }
    }
}
