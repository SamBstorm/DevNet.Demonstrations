using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Methode_02
{
    public struct Contact
    {
        public string prenom;
        public string nom;
        public DateTime dateDeNaissance;
        public List<Email> emails;
        public List<Telephone> telephones;

        public string Info() {
            string result = $"{nom} {prenom}\nNé le {dateDeNaissance}\n";
            foreach (Email mail in emails)
            {
                result += mail.FullMail() + "\n";
            }
            foreach (Telephone phone in telephones)
            {
                result += phone.FullPhone() + "\n";
            }
            return result;
        }
    }
}
