using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Time temps_1 = new Time(); //temps.hours = 0 ; temps.minutes = 0 ; temps.seconds = 0;
            //Pas de constructeur : donc constructeur par defaut => toutes variables obtiennent les valeurs par défaut.
            Time temps_2;
            temps_2.hours = 16;
            temps_2.minutes = 17;
            temps_2.seconds = 20;


            Time temps_3 = temps_1;

            temps_3.hours = 17;

            Console.WriteLine($"{temps_1.hours} : {temps_1.minutes} : {temps_1.seconds}");

            Chrono c1 = new Chrono();
            c1.times = new List<Time>();
            c1.times.Add(temps_1);
        }
    }
}
