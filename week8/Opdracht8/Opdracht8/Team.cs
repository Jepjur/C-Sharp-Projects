using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Team
    {
        //Maak 4 leden aan
        Lid l1 = new Lid("Jasper", "Geschiedenis");
        Lid l2 = new Lid("Wouter", "Sport");
        Lid l3 = new Lid("Peter", "Wetenschap");
        Lid l4 = new Lid("Kick", "Muziek");

        //Methodes

            // NANI ??????????????
        public void PrintAlleLeden()
        {
            l1.Print();
            l2.Print();
            l3.Print();
            l4.Print();
        }
    }
}
