using System;

namespace Demo_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Incrémentation
            int i = 5;
            int j = i++; // incrémentation ne touche que la variable concerné, ici c'est i.
                         // '++i' est prioritaire face à 'j =' : i augmente de 1 avant affectation de j => 5+1 sera le résultat de j;
                         // 'i++' est non-prioritaire face à 'j =' : i augmente de 1 après affectation de j => 5 sera le résultat de j;

            Console.WriteLine($"i : {i} - j: {j} "); 
            #endregion

            #region Affectation avancée
            int k = 7;  //0  0  0  0  1  1  1  => Vaut 7
                        //64 32 16 8  4  2  1  => 4 + 2 + 1
            Console.WriteLine($"k : {k}");
            k <<= 1;    //0  0  0  1  1  1  0  => Vaut 14
                        //64 32 16 8  4  2  1  => 8 + 4 + 2 
            Console.WriteLine($"k : {k}");
            k >>= 1;    //0  0  0  0  1  1  1  => Vaut 7
                        //64 32 16 8  4  2  1  => 4 + 2 + 1
            Console.WriteLine($"k : {k}");

            i += 2;     //i vaut 6, on y ajoute 2
            //i *= 0.5; //Attention, i est un int, on ne peut le transformer en double par la multiplication
            double x = i * 0.5; 
            #endregion


            #region Ternaire
            Console.WriteLine("Bonjour, Veuillez indiquer votre genre :\n1) Femme\n2) Homme\n3) Autre");
            int genderId = int.Parse(Console.ReadLine());

            string message = "Bonjour, ";
            message += (genderId == 1) ? "Madame" : (genderId == 2) ? "Monsieur" : "personne...";

            Console.WriteLine(message);

            //h:mm:ss

            int heure = 12;
            int minute = 9;
            int seconde = 3;

            Console.WriteLine($"{heure} : {((minute < 10) ? "0" + minute : minute)} : {((seconde < 10) ? "0" + seconde : seconde)}"); 
            #endregion

            #region Coalesce
            string toto = null;
            string titi = null;
            string tata = "Sam";

            string name = toto ?? tata ?? titi;
            #endregion

            #region typeof + GetType()
            Type type_de_nb = typeof(int);

            int nb = 5;

            if (nb.GetType() == type_de_nb) Console.WriteLine("nb stocke une valeur de type int");
            else Console.WriteLine("nb ne contient pas une valeur de type int");

            Console.WriteLine(typeof(int));      //Permet de récupérer le Type en tant que variable
            Console.WriteLine(nb.GetType());    //Permet de connaitre le type de la valeur stocker en variable 
            #endregion
        }
    }
}
