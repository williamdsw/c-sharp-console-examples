using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class AnonymousClasses
    {
        public AnonymousClasses ()
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

            Console.WriteLine ("First Name = " + person.firstName);
            Console.WriteLine ("Last Name = " + person.lastName);
            Console.WriteLine ("Nationality  = " + person.nationality);
            Console.WriteLine ("Position = " + person.position);
            Console.WriteLine ("Appearances = " + person.appearances);
            Console.WriteLine ("Goals = " + person.goals);
        }
    }
}
