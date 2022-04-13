using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode_03
{
    public struct Demonstration
    {
        public string resultat;

        public void Calculatrice(int nombre,char operateur, int nombre2) {
            resultat = $"{nombre} {operateur} {nombre2} = ";
            if (operateur == '/' && nombre2 == 0) {
                resultat += "Calcul impossible";
                return;
            }
            switch (operateur)
            {
                case '+':
                    resultat += nombre + nombre2;
                    break;
                case '-':
                    resultat += nombre - nombre2;
                    break;
                case '*':
                    resultat += nombre * nombre2;
                    break;
                case '/':
                    resultat += nombre / nombre2;
                    break;
                default:
                    resultat = "Opérateur incorrect";
                    break;
            }
        }

        public string CalculatriceFonction(int nombre, char operateur, int nombre2)
        {
            resultat = $"{nombre} {operateur} {nombre2} = ";
            if (operateur == '/' && nombre2 == 0)
            {
                resultat += "Calcul impossible";
                return resultat;
            }
            switch (operateur)
            {
                case '+':
                    return resultat + (nombre + nombre2);
                    break;
                case '-':
                    return resultat + (nombre - nombre2);
                    break;
                case '*':
                    return resultat + (nombre * nombre2);
                    break;
                case '/':
                    return resultat + (nombre / nombre2);
                    break;
                default:
                    return "Opérateur incorrect";
                    break;
            }
        }
    }
}
