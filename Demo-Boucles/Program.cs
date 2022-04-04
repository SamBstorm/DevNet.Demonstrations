using System;

namespace Demo_Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez m'indiquer le nombre d'étudiants : ");
            #region While
            //string input = Console.ReadLine();                  //Initialisation de la variable pour une condition valide
            //ushort nbStudent;
            //while (!ushort.TryParse(input, out nbStudent))      //Condition soumise à l'ide d'une variable pour qu'elle puisse changée
            //{
            //    Console.WriteLine("Valeur incorrecte...");
            //    input = Console.ReadLine();                     //Changement de valeur pour que la condition puisse changée
            //}
            #endregion
            #region For
            ushort nbStudent;
            for (string input = Console.ReadLine(); !ushort.TryParse(input, out nbStudent); input = Console.ReadLine()) {
                Console.WriteLine("Valeur incorrecte...");
            }
            #endregion
            //traitement final 
            Console.WriteLine($"Vous avez dit {nbStudent} étudiants.");
        }
    }
}
