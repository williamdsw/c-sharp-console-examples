using System;

namespace c_sharp_console_examples
{
    public class AnonymousClassUse
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public AnonymousClassUse ()
        {
            var person = new
            {
                firstName = "David",
                lastName = "Beckham",
                nationality = "England",
                position = "Midfielder",
                appearances = 523,
                goals = 97
            };

            // Shows data
            Console.WriteLine ("First Name = " + person.firstName);
            Console.WriteLine ("Last Name = " + person.lastName);
            Console.WriteLine ("Nationality  = " + person.nationality);
            Console.WriteLine ("Position = " + person.position);
            Console.WriteLine ("Appearances = " + person.appearances);
            Console.WriteLine ("Goals = " + person.goals);
        }
    }
}