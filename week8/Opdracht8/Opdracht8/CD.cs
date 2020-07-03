using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class CD
    {
        //Fields
        string titel;
        string uitvoerder;
        int hoeveelheidLiedjes;

        //Constructor
        public CD(string titel, string uitvoerder)
        {
            this.titel = titel;
            this.uitvoerder = uitvoerder;
        }

        //Methods
        public string OpvragenTitel()
        {
            return titel;
        }

        public string OpvragenUitvoerder()
        {
            return uitvoerder;
        }

        public int OpvragenHoeveelheidLiedjes()
        {
            return hoeveelheidLiedjes;
        }

        public void Overzicht()
        {
            Console.WriteLine("Titel: " + titel);
            Console.WriteLine("Uitvoerder: " + uitvoerder);
            Console.WriteLine("Hoeveelheid liedjes: " + hoeveelheidLiedjes);
        }
    }
}
