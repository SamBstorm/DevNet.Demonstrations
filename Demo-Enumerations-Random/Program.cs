using System;

namespace Demo_Enumerations_Random
{
    class Program
    {
        public static Random RNG = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Avec une énumération ayant des identifiants simples :");
            int randomId = RNG.Next(0, Enum.GetNames(typeof(Animals)).Length);

            Animals myPet = (Animals)randomId;
            Console.WriteLine(myPet.ToString());
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Avec une énumération ayant des identifiants désordonnés : ");

            string[] studentNames = Enum.GetNames(typeof(Students));
            randomId = RNG.Next(0, studentNames.Length);

            Students student = Enum.Parse<Students>(studentNames[randomId]);
            Console.WriteLine(student.ToString());

        }
    }
}
