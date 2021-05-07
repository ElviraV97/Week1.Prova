using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Prova.Categorie;

namespace Week1.Prova
{
    public enum LivelloApprovazione
    {
        Manager,
        OperationalManager,
        CEO,
        NonApprovata
    }
    class GestioneSpese
    {
        public static void GestioneNuovoFile(object sender, FileSystemEventArgs e)
        {
            using StreamReader reader = File.OpenText(e.FullPath);

            Console.WriteLine($"Lettura di {e.Name}");
            string line;

            //string instanceData = reader.ReadLine().Split(":")[1];

            string scrittura = "";
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                string[] values = line.Split(";");

                int.TryParse(values[3], out int importo);

                Console.WriteLine(importo);

                // Approva Spese
                var manager = new ManagerHandler();
                var opman = new OperationalManagerHandler();
                var ceo = new CEO();

                manager.SetNext(opman).SetNext(ceo);

                LivelloApprovazione livAppr = manager.Handle(importo);

                string cat = values[1];

                double rimborso = 0;

                if (livAppr != LivelloApprovazione.NonApprovata)
                {
                    rimborso = CategorieFactory.FactoryCategoria(cat).Rimborso(importo);
                    scrittura += $"{values[0]};{values[1]};{values[2]};APPROVATA;{livAppr};{importo}\n";
                }
                else
                    scrittura += $"{values[0]};{values[1]};{values[2]};RESPINTA;-;-\n";

                Console.WriteLine(livAppr + " " + cat + " " + importo + " " + rimborso);

            }

            reader.Close();

            using StreamWriter writer = File.CreateText(@"C:\Users\elvira.verrengia\source\repos\Week1.Prova\spese_elaborate.txt");
            writer.Write(scrittura);

        }
    }
}
