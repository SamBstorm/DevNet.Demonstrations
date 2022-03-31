using System;

namespace Demo_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello world!";
            string s2 = s1;
            Console.WriteLine($"s1 : {s1}");
            Console.WriteLine($"s2 : {s2}");
            Console.WriteLine(ReferenceEquals(s1,s2));
            s1 = "Toto";
            Console.WriteLine($"s1 : {s1}");
            Console.WriteLine($"s2 : {s2}");
            Console.WriteLine(ReferenceEquals(s1, s2));

        }
    }
}
