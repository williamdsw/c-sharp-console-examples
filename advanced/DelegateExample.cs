using System;

namespace c_sharp_console_examples
{
    public class DelegateExample
    {
        private const int MAX_NUMBER_OF_OCCURRENCES = 100;
        private delegate void Delegate ();

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public DelegateExample ()
        {
            // Sets the new delegate
            Delegate myDelegate = new Delegate (PrintRandomIntegers);
            myDelegate ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void PrintRandomIntegers ()
        {
            // Prints a number between 0 and 100
            Console.WriteLine ("Random Integers between 0 and 100:");
            Random random = new Random ();
            for (int i = 0; i < MAX_NUMBER_OF_OCCURRENCES; i++)
            {
                int nextInteger = random.Next (MAX_NUMBER_OF_OCCURRENCES);
                Console.Write ($" {nextInteger} ");
            }
        }
    }
}