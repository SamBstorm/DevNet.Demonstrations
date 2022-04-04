using System;

namespace Demo_PatternMatching
{
    class Program
    {
        static Random RNG = new Random();
        static void Main(string[] args)
        {
            var o = FonctionDeTest();        //Aucune idée du type stocké dans mon object
                                                //Un object peut contenir tout type de valeur
                                                //Notre fonction nous stockera soit un entier, un réel ou un text...

            switch (o)
            {
                //case int:
                //    int i = (int)o;
                case int i:
                    i *= 5;
                    Console.WriteLine($"i est un entier = {i}");
                    break;
                //case double:
                //    double d = (double)o;
                case double d:
                    d /= 0.5;
                    Console.WriteLine($"d est un réel = {d}");
                    break;
                case string s when int.TryParse(s, out int j):
                    j += 5;
                    Console.WriteLine($"j est un entier, provenant d'un string = {j}");
                    break;
                //case string:
                //    string s = (string)o;
                case string s:
                    Console.WriteLine(s.ToUpper());
                    Console.WriteLine($"s est un text = {s}");
                    break;
                default:
                    Console.WriteLine("Object incompatible");
                    break;
            }


        }

        static object FonctionDeTest() {
            object result = null;
            switch (RNG.Next(1,6))
            {
                case 1:
                    result = 1;
                    break;
                case 2:
                    result = "un";
                    break;
                case 3:
                    result = 1.0;
                    break;
                case 4:
                    result = true;
                    break;
                case 5:
                    result = "1";
                    break;
            }
            return result;
        }
    }
}


//0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0
//               .....             16384 8192 4096 2048 1024 512 256 128 64 32 16  8  4  2  1  -
//1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  0    2_147_483_647
//               .....             16384 8192 4096 2048 1024 512 256 128 64 32 16  8  4  2  1  -
//0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  0  1  0  1  0  0    10
//               .....             16384 8192 4096 2048 1024 512 256 128 64 32 16  8  4  2  1  -
//1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  1  0  1  0  1  1    -2_147_483_638
//               .....             16384 8192 4096 2048 1024 512 256 128 64 32 16  8  4  2  1  -


