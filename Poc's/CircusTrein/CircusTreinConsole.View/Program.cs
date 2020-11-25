using CircusTrein;
using CircusTrein.Application;
using System;
using System.Collections.Generic;

namespace CircusTrein.View
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            List<Dier> dieren = new List<Dier>();
            while (exit == false)
            {
                Console.WriteLine("Naam van het dier: \n");
                string naam = Console.ReadLine();
                Console.WriteLine("\nDieet:\n Herbivoor = 1\n Carnivoor = 2");
                string dieet = Console.ReadLine();
                Console.WriteLine("\nGrote: \n Klein = 1 \n Middel = 3 \n Groot = 5");
                string grote = Console.ReadLine();
                dieren.Add(Algoritme.AddAnimal(naam, dieet, grote));
                Console.WriteLine("\nnog een dier toevoegen = 1 \nsorteer = 2\n ");
                int gemaakteKeuze = int.Parse(Console.ReadLine());
                exit = gemaakteKeuze == 2;
            }
           List<Wagon> wagonLijstCompleet = Algoritme.RunAlgoritme(dieren);

            foreach (Wagon wagon in wagonLijstCompleet)
            {
                Console.WriteLine(wagon.Naam + " - Gewicht: " + wagon.HuidigeGrote);
                foreach (Dier dier in wagon.Dieren)
                {
                    Console.WriteLine("    " + dier.naam);
                }
                Console.WriteLine("");
            }
        }
    }
}
