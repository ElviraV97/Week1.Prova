using System;
using System.IO;

namespace Week1.Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();

            fsw.Path = @"C:\Users\elvira.verrengia\source\repos\Week1.Prova";
            fsw.Filter = "*.txt";
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;

            fsw.EnableRaisingEvents = true;
            fsw.Created += GestioneSpese.GestioneNuovoFile;

            
            Console.WriteLine("Inserisci q per chiudere il programma");
            while (Console.Read() != 'q');


        }

        
    }
}
