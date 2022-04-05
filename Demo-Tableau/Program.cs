using System;

namespace Demo_Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] eleves = new string[12];
            //eleves[0] = "Benjamin";
            //eleves[1] = "Nathalie";
            //eleves[2] = "Grégory";
            //eleves[3] = "Maïlys";
            //eleves[4] = "Bryan";
            //eleves[5] = "Ryan";
            //eleves[6] = "Sylvain";
            //eleves[7] = "Olivier";

            string[] eleves = { "Benjamin","Nathalie","Grégory","Maïlys","Bryan","Ryan","Sylvain","Olivier", "Antonio", "Denis", "Nabil", "Paulin" };
            bool[] presences = new bool[eleves.Length];
            for (int i = 0; i < eleves.Length; i++)
            {
                Console.WriteLine($"{eleves[i]} : {((presences[i])?"Présent":"Absent")}");
            }

            //object[,] presencesObj = new object[2, 12];
            object[,] presenceObj = { 
                { "Benjamin", "Nathalie", "Grégory", "Maïlys", "Bryan", "Ryan", "Sylvain", "Olivier", "Antonio", "Denis", "Nabil", "Paulin" }, 
                { false, false, false, false, false, false, false, false, false, false, false, false }
            };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{presenceObj[0,i]} : {(((bool)presenceObj[1,i])?"Présent":"Absent")}");
            }
            

            
        }
    }
}