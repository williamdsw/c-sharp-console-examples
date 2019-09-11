using System;

namespace c_sharp_console_examples
{
    public class RecursiveFunctionExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTORS

        public RecursiveFunctionExample ()
        {
            Console.WriteLine ("Factorial of 6 = {0}", Factorial (6));
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private int Factorial (int number)
        {
            if (number == 1)
            {
                return number;
            }

            return number * Factorial (number - 1);
        }
    }
}