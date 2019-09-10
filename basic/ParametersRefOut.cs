using System;

namespace c_sharp_console_examples
{
    class ParametersRefOut
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public ParametersRefOut ()
        {
            // initial value
            int myValue = 100;
            Console.WriteLine ("Initial value = " + myValue);

            // initial increment
            Increment (myValue);
            Console.WriteLine("Incremented value = " + myValue);

            // ref increment
            Increment (ref myValue);
            Console.WriteLine ("Incremented value using REF = " + myValue);

            // out initialization
            int otherValue;
            Initialize (out otherValue);
            Console.WriteLine ("Value initializated using OUT = " + otherValue);
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void Increment (int value)
        {
            value++;
        }

        private void Increment (ref int value)
        {
            value++;
        }

        private void Initialize (out int value)
        {
            value = 10;
        }
    }
}
