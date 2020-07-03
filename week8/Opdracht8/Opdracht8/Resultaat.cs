using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Resultaat
    {
        //Fields
        double graad;
        double tempGraad;
        int hoeveelheidCijfers;

        //Constructor
        public Resultaat()
        {
            graad = 0;
            tempGraad = 0;
            hoeveelheidCijfers = 0;
        }

        public void toevoegenCijfer(int cijfer)
        {
            tempGraad += cijfer;
            hoeveelheidCijfers++;
        }

        public void behaaldeResultaat()
        {
            graad = (tempGraad / hoeveelheidCijfers);
            if (graad < 50)
            {
                Console.WriteLine("Niet geslaagd");
            }
            else if (graad >= 50 && graad < 68)
            {
                Console.WriteLine("Voldoende");
            }
            else if (graad >= 68 && graad < 75)
            {
                Console.WriteLine("Onderscheiding");
            }

            else if (graad >= 75 && graad < 85)
            {
                Console.WriteLine("Grote onderscheiding");
            }
            else
            {
                Console.WriteLine("Grootste onderscheiding");
            }
        }

    }
}
