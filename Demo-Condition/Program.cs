using System;

namespace Demo_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour, votre prénom :");
            string nom = Console.ReadLine();
            Console.WriteLine("Veuillez indiquer votre âge :");
            int age;
            bool age_isOk = int.TryParse(Console.ReadLine(), out age);
            if (!age_isOk)
            {
                Console.WriteLine("Merci, au revoir!");
            }
            else if (age < 18)
            {
                Console.WriteLine($"Reviens dans {18 - age} ans.");
            }
            else
            {
                Console.WriteLine("Êtes vous belge? Oui | Non");
                string nationalite = Console.ReadLine();
                switch (nationalite.ToUpper())
                {
                    case "OUI":
                        Console.WriteLine("Bienvenu sur le site de la lotterie nationnale.");
                        break;
                    case "NON":
                        Console.WriteLine("Désolé, seul les joueurs belges sont autorisés.");
                        break;
                    default:
                        Console.WriteLine("Réponse invalide.");
                        break;
                }
            }
        }
    }
}
