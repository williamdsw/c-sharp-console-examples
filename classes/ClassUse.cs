using System;

namespace c_sharp_console_examples
{
    class ClassUse
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public ClassUse ()
        {
            // Instance and data
            Person person = new Person ();
            person.SetFirstName ("Al");
            person.SetLastName ("Simmons");
            person.SetAge (30);
            person.SetHeight (1.82);
            person.SetWeight (80);

            // Shows Data
            Console.WriteLine ("Name : " + person.GetFullName ());
            Console.WriteLine ("Age : " + person.GetAge ());
            Console.WriteLine ("Height : " + person.GetHeight () + " m ");
            Console.WriteLine ("Weight : " + person.GetWeight () + " kg ");
        }
    }
}
