using System;

namespace Demo_Static01
{
    class Program
    {
        static void Main(string[] args)
        {
            Localisation centreTrakk = new Localisation();
            centreTrakk.City = "Namur";
            centreTrakk.ZipCode = "5000";
            centreTrakk.Country = "BELGIUM";
            centreTrakk.Street = "Av. Reine Astrid";
            centreTrakk.Number = "16";
            centreTrakk.BoxNumber = null;

            Localisation centreCiney = new Localisation();
            centreCiney.City = "Ciney";
            centreCiney.ZipCode = "5590";
            centreCiney.Country = "BELGIUM";
            centreCiney.Street = "Allée des artisants";
            centreCiney.Number = "19";
            centreCiney.BoxNumber = null;

            MaLocalisation.Country = "BELGIUM";
            MaLocalisation.City="Florennes";
            MaLocalisation.ZipCode="5621";
            MaLocalisation.Street="Boulevard Philippe";
            MaLocalisation.Number="25";
            MaLocalisation.BoxNumber="2";
        }
    }
}
