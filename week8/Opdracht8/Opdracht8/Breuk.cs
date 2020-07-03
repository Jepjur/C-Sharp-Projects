using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Breuk
    {
        int teller;
        int noemer;

        //Default constructor
        public Breuk()
        {
            teller = 8;
            noemer = 4;
        }

        //Constructor met user input
        public Breuk(int teller, int noemer)
        {
            this.teller = teller;
            this.noemer = noemer;
        }

        //Methods
        public int BerekenQuotient()
        {
            return (teller * noemer);
        }

        public int OpvragenNoemer()
        {
            return noemer;
        }

        public int OpvragenTeller()
        {
            return teller;
        }


        public void AanpassenWaarde(int nieuweTeller, int nieuweNoemer)
        {
            teller = nieuweTeller;
            noemer = nieuweNoemer;
        }
    }
}
