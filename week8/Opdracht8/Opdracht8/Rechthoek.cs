﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Rechthoek
    {
        //Fields
        int basis;
        int hoogte;

        //Constructor
        public Rechthoek(int basis, int hoogte)
        {
            this.basis = basis;
            this.hoogte = hoogte;
        }

        //Methods
        public int BerekenOppervlakte()
        {
            return (hoogte * basis);
        }

        public void VeranderWaarde(int nieuweBasis, int nieuweHoogte)
        {
            basis = nieuweBasis;
            hoogte = nieuweHoogte;
        }

        public int OpvragenHoogte()
        {
            return hoogte;
        }
        public int OpvragenBasis()
        {
            return basis;
        }
    }
}
