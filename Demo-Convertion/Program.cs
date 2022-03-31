using System;

namespace Demo_Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Veuillez indiquer le nombre d'élèves présents aujourd'hui :");
            //string nbEleves_input = Console.ReadLine();
            //int nbEleves;
            //bool nbEleves_isCorrect = int.TryParse(nbEleves_input, out nbEleves);
            //Console.WriteLine($"Avons-nous eu une information correct : {nbEleves_isCorrect}");
            //Console.WriteLine($"Nous avons comptabilisé : {nbEleves} élèves.");


            Console.WriteLine("Veuillez indiquer la moyenne des élèves :");
            string moyenne_input = Console.ReadLine();
            double moyenne;
            bool moyenne_isCorrect = double.TryParse(moyenne_input, out moyenne);
            Console.WriteLine($"Avons-nous eu une information correct : {moyenne_isCorrect}");
            Console.WriteLine($"Nous avons comptabilisé une moyenne de : {moyenne}/20.");
            Console.WriteLine($"Nous avons comptabilisé une moyenne de : {(int)moyenne}/20.");
        }
    }
}
