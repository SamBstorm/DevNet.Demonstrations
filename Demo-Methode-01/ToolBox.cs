using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode_01
{
    public struct ToolBox
    {
        // niveau d'accessibilité : public / private
        // type de retour : void : ne retourne rien / n'importe quel type (struct ou un object)
        // nom de la méthode : correspond à la description de l'action ecrit en CamelCase
        // parenthèses : ( permet de placer des paramètres (optionnel ou pas) )
        public int IntReadLine(string messageIntro)
        {
            //bloc d'instruction : aucune limite d'instruction et seront exécuté de manière séquentielle
            int result;
            Console.WriteLine(messageIntro);
            while (!int.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Veuillez réessayer :");
            return result;
        }

        public int IntReadLine()
        {
            //bloc d'instruction : aucune limite d'instruction et seront exécuté de manière séquentielle
            int result;
            while (!int.TryParse(Console.ReadLine(), out result)) Console.WriteLine("Veuillez réessayer :");
            return result;
        }
    }
}
