using System;

namespace Demo_Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer votre genre :");
            foreach (string genre_name in Enum.GetNames(typeof(Genres)))
            {
                Console.WriteLine($"- {genre_name}");
            }
            string gender = Console.ReadLine();
            Genres user_genre;
            while (!Enum.TryParse<Genres>(gender, out user_genre)) Console.WriteLine($"{gender} non disponible...");
            
            if (user_genre == Genres.Femme) Console.WriteLine("Bonjour Madame.");
            else if (user_genre == Genres.Homme) Console.WriteLine("Bonjour Monsieur.");
            else Console.WriteLine("Bonjour.");
        }
    }
}
