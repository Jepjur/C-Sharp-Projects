using System;

namespace SnailRace
{
    class Snail
    {
        //Fields
        int minimumSpeed;
        int maximumSpeed;
        string name;

        //Constructors

        //Default constructor
        public Snail()
        {
            new Snail(10, 20, "Bob");
        }

        //Custom constructor
        public Snail (int minimumSpeed, int maximumSpeed, string name)
        {
            this.minimumSpeed = minimumSpeed;
            this.maximumSpeed = maximumSpeed;
            this.name = name;
        }

        //Methods
        public int Move()
        {
            Random rand = new Random();
            int pace = rand.Next(minimumSpeed, maximumSpeed + 1);
            return pace;
        }
        public override string ToString()
        {
            return name.ToString();
        }

    }
}
