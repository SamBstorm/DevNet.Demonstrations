using System;

namespace Demo_Methode_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Demonstration demo = new Demonstration();
            demo.Calculatrice(18,'/',0);
            
            Console.WriteLine($"Le résultat du test est : {demo.resultat}.");
            Console.WriteLine($"Le résultat du test est : {demo.CalculatriceFonction(18, '/', 0)}.");
        }
    }
}
