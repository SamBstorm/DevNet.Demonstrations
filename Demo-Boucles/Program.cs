using System;

namespace Demo_Boucles
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Avec Boucle While
            //Console.WriteLine("Veuillez m'indiquer le nombre d'étudiants : ");
            //#region While
            //string input = Console.ReadLine();                  //Initialisation de la variable pour une condition valide
            //ushort nbStudent;
            //while (!ushort.TryParse(input, out nbStudent))      //Condition soumise à l'ide d'une variable pour qu'elle puisse changée
            //{
            //    Console.WriteLine("Valeur incorrecte...");
            //    input = Console.ReadLine();                     //Changement de valeur pour que la condition puisse changée
            //}
            //#endregion

            ////traitement final 
            //Console.WriteLine($"Vous avez dit {nbStudent} étudiants.");
            #endregion

            #region Avec Boucle For
            //Console.WriteLine("Veuillez m'indiquer le nombre d'étudiants : ");
            //#region For (si on devait refaire le while dedans, complèxe : peu commun)
            ////ushort nbStudent;
            ////for (string input = Console.ReadLine(); !ushort.TryParse(input, out nbStudent); input = Console.ReadLine()) {
            ////    Console.WriteLine("Valeur incorrecte...");
            ////}
            //#endregion
            //#region For (dans un contexte d'itération numérique : plus commun)
            //for (ushort i = 1; i <= nbStudent; i++)
            //{
            //    Console.WriteLine($"{i} étudiant{((i == 1) ? "" : "s")}");
            //}
            //#endregion
            ////traitement final 
            //Console.WriteLine($"Vous avez dit {nbStudent} étudiants.");
            #endregion

            #region Avec Boucle Do ... While
            ushort nbStudent;
            string input;
            string message = "Veuillez m'indiquer le nombre d'étudiants : ";
            do
            {
                Console.WriteLine(message);
                message = "Valeur incorrecte...";
                input = Console.ReadLine();
            } while (!ushort.TryParse(input, out nbStudent));
            //traitement final 
            Console.WriteLine($"Vous avez dit {nbStudent} étudiants.");
            #endregion
        }
    }
}
