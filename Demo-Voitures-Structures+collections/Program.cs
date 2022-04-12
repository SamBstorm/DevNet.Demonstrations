using System;
using System.Collections.Generic;

namespace Demo_Voitures_Structures_collections
{
    class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            string[] teams = { "Ferrari", "Mercedes", "Lamborghini", "Alfa Romeo", "Skoda" };
            List<Voiture> voitures = new List<Voiture>();
            int nbVoiture;
            Console.WriteLine("Veuillez indiquer le nombre de voiture (entre 1 et 12):");
            while (!int.TryParse(Console.ReadLine(), out nbVoiture)) Console.WriteLine("Erreur veuillez réessayer:");
            for (int i = 0; i < nbVoiture; i++)
            {
                Voiture car;
                car.number = i + 1;
                car.team = teams[RNG.Next(0, teams.Length)];
                Console.WriteLine($"Veuillez indiquer le nom du pilote qui conduira la voiture {car.team} {car.number}:");
                car.driver_name = Console.ReadLine();
                voitures.Add(car);
            }

            foreach (Voiture voit in voitures)
            {
                Console.WriteLine($"{voit.number} - {voit.team} : {voit.driver_name}");
            }
        }
    }
}
