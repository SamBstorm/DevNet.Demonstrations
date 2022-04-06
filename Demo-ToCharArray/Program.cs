using System;

namespace Demo_ToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello world!";                //Est une chaine de caractère dans une variable de type string
            char[] messageChars = message.ToCharArray();    //On le transforme en tableau de caractères avec ToCharArray()
                                                            //['H','e','l','l','o',' ','w','o','r','l','d','!']

            foreach (char messageChar in messageChars)
            {
                Console.WriteLine(messageChar);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(messageChars[i]);
            }
        }
    }
}
