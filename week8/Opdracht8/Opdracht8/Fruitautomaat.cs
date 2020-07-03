using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Fruitautomaat
    {
        //Fields
        int appels;
        int peren;
        
        //Constructor
        public Fruitautomaat()
        {
            appels = 30;
            peren = 20;
        }

        public Fruitautomaat(int appels, int peren)
        {
            this.appels = appels;
            this.peren = peren;
        }

        //Methods
        public void AppelsAanvullen(int aanvullenAppels)
        {
            if (appels + aanvullenAppels > 50)
            {
                throw new ArgumentException("De machine mag niet meer dan 50 appels bevatten");
            }
            else
            {
                appels += aanvullenAppels;
            }
        }
           
        public void PerenAanvullen(int aanvullenPeren)
        {
            if (peren + aanvullenPeren > 50)
            {
                throw new ArgumentException("De machine mag niet meer dan 50 peren bevatten");
            }
            else
            {
                peren += aanvullenPeren;
            }
        }
        public void AppelsKopen(int kopenAppels)
        {
            if (appels < kopenAppels)
            {
                throw new ArgumentException("Er zijn niet genoeg appels te koop");
            }
            else
            {
                appels -= kopenAppels;
            }
        }
        public void PerenKopen(int kopenPeren)
        {
            if (peren < kopenPeren)
            {
                throw new ArgumentException("Er zijn niet genoeg peren te koop");
            }
            else
            {
                peren -= kopenPeren;
            }
        }
        public int OpvragenVoorraad()
        {
            return (appels + peren);
        }

        public void OpvragenPeren()
        {
            if (peren < 1)
            {
                Console.WriteLine("De peren zijn uitverkocht");
            }
            else
            {
                Console.WriteLine("De peren zijn nog niet uitverkocht");
            }
        }
        public void OpvragenAppels()
        {
            if (appels < 1)
            {
                Console.WriteLine("De appels zijn uitverkocht");
            }
            else
            {
                Console.WriteLine("De appels zijn nog niet uitverkocht");
            }
        }

    }
}
