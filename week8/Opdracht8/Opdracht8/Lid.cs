using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Opdracht8
{
    class Lid
    {
        //Fields
        string naam;
        string specialiteit;

        //Constructor
        public Lid(string naam, string specialiteit)
        {
            this.naam = naam;
            this.specialiteit = specialiteit;
        }

        //Methods
        public void Print()
        {
            Console.WriteLine("Naam: " + naam);
            Console.WriteLine("Specialiteit: " + specialiteit);
        }
    }
}
