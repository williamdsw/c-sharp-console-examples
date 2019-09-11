using System;

namespace c_sharp_console_examples
{
    public class GenericFunctionExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public GenericFunctionExample ()
        {
            Swap<int> (10, 45);
            Swap<double> (0.45, 11.34);
            Swap<string> ("Hello", "World");
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void Swap<type> (type first, type second)
        {
            type temp = first;
            first = second;
            second = temp;

            // Output
            Console.WriteLine ($"Type: {temp.GetType ()}");
            Console.WriteLine ($"Temp: {temp}");
            Console.WriteLine ($"First: {first}");
            Console.WriteLine ($"Second: {second}");
        }
    }
}