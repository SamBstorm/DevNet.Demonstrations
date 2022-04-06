using System;
using System.Collections.Generic;

namespace Demo_Collections_Generiques
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> eleves = new List<string>(new string[] { "Benjamin", "Nathalie", "Grégory", "Maïlys", "Bryan", "Ryan", "Sylvain", "Olivier", "Antonio", "Denis", "Nabil", "Paulin" });

            foreach (string eleve in eleves)
            {
                Console.WriteLine(eleve);
            }
        }
    }
}
