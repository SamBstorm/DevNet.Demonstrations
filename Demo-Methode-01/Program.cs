using System;

namespace Demo_Methode_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age;
            //récupérer l'age
            ToolBox tools;
            tools.IntReadLine();
            age = tools.IntReadLine("Veuillez indiquer l'âge :");

            Console.WriteLine($"Hooo vous avez {age} ans!");

            int day;
            day = tools.IntReadLine("Veuillez indiquer le jour de votre naissance :");
            // récupérer le jour de naissance

            int month = tools.IntReadLine("Veuillez indiquer le mois de votre naissance :");
            // récupérer le mois de naissance

        }
    }
}
