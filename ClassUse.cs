using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class ClassUse
    {
        public ClassUse ()
        {
            Person person = new Person ();

            person.setFirstName ("Al");
            person.setLastName ("Simmons");
            person.setAge (30);
            person.setHeight (1.82);
            person.setWeight (80);

            Console.WriteLine ("Name : " + person.getFullName ());
            Console.WriteLine ("Age : " + person.getAge ());
            Console.WriteLine ("Height : " + person.getHeight () + " m ");
            Console.WriteLine ("Weight : " + person.getWeight () + " kg ");
        }
    }
}
