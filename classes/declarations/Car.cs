using System;

namespace c_sharp_console_examples
{
    public class Car
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTORS
        
        public Car ()
        {
            Console.WriteLine ("Initializing car...");
            Console.WriteLine ("Initializing motor...");
            Motor motor = new Motor ();
            motor.Growl ();
        }

        // Nested class
        private class Motor
        {
            public void Growl ()
            {
                Console.WriteLine ("BRAAAAAWWWWWWWWWWWW");
            }
        }
    }
}