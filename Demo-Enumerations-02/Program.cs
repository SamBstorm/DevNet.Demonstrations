using System;

namespace Demo_Enumerations_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez choisir une couleur parmis celles proposées :");
            string[] colorNames = Enum.GetNames(typeof(ConsoleColor));
            for (int i = 0; i < colorNames.Length; i++)
            {
                Console.WriteLine($"{i} ) {colorNames[i]}");
            }
            int user_choice;
            while (!int.TryParse(Console.ReadLine(), out user_choice)) Console.WriteLine("Veuillez re-sélectionner :");
            Console.ForegroundColor = (ConsoleColor)user_choice;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Faites une combinaison de touches :");
            ConsoleKeyInfo info = Console.ReadKey();
            while (info.Key != ConsoleKey.F4)
            {
                Console.WriteLine($"{info.Key} - {info.Modifiers}");
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("On monte!");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("On Descend!");
                        break;
                    default:
                        break;
                }
                info = Console.ReadKey();
            }

        }
    }
}
