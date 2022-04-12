using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode_02
{
    public struct Email
    {
        public string pseudoMail;
        public string domaine;

        public string FullMail() {
            return $"{pseudoMail}@{domaine}";
        }
    }
}
