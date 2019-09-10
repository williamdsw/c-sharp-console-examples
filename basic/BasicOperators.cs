using System;

namespace c_sharp_console_examples
{
    class BasicOperators
    {
        private double a = 200;
        private double b = 35;
        private double sum;
        private double substract;
        private double multiply;
        private double divide;
        private double modulus;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public BasicOperators ()
        {
            sum = (a + b);
            substract = (a - b);
            multiply = (a * b);
            divide = (a / b);
            modulus = (a % b);

            // Shows data
            Console.WriteLine ($"a = {a}; b = {b};");
            Console.WriteLine ("sum = " + sum);
            Console.WriteLine ("substract = " + substract);
            Console.WriteLine ("multiply = " + multiply);
            Console.WriteLine ("divide = " + divide);
            Console.WriteLine ("modulus = " + modulus);
        }
    }
}
