using System;
using System.Collections;

namespace Demo_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList listEleves = new ArrayList();     // [ ]
            ArrayList listEleves = new ArrayList(new string[] { "Benjamin", "Nathalie", "Grégory", "Maïlys", "Bryan", "Ryan", "Sylvain", "Olivier", "Antonio", "Denis", "Nabil", "Paulin" });     // [ ]
            listEleves.Add("Benjamin");
            listEleves.Remove("Benjamin");

            //foreach (string eleve in listEleves)
            //{
            //    Console.WriteLine(eleve.ToUpper());
            //}

            for (int i = 0; i < listEleves.Count; i++)
            {
                string eleve = (string)listEleves[i];
                Console.WriteLine(eleve.ToUpper());
            }

            Hashtable listPresence = new Hashtable();

            foreach (string eleve in listEleves)
            {
                listPresence.Add(eleve, true);
            }

            foreach (string cle in listPresence.Keys)
            {
                Console.WriteLine($"{cle} : {listPresence[cle]}");
            }

            //foreach (bool value in listPresence.Values) {
            //    Console.WriteLine(value);
            //}

            foreach (DictionaryEntry entry in listPresence)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
        }
    }
}
