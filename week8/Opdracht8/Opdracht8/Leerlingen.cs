using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht8
{
    class Leerlingen
    {
        //Fields
        string firstName;
        string lastName;
        string className;

        //Constructor
        public Leerlingen(string firstName, string lastName, string className)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.className = className;
        }

        //Methods
        public void updateUser(string newClassName)
        {
            className = newClassName;
        }

        public void displayUserInfo()
        {
            Console.WriteLine(firstName + " " + lastName + " " + className);
        }
    }
}
