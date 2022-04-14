using System;

namespace Demo_Enumerations_Random
{
    class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            string[] animalsNames = Enum.GetNames(typeof(Animals));
            int randomId = RNG.Next(0, animalsNames.Length);

            Animals myPet = Enum.Parse<Animals>(animalsNames[randomId]);
            Console.WriteLine(myPet.ToString());
        }
    }
}
