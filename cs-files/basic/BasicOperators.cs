using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
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

        public BasicOperators ()
        {
            sum = a + b;
            substract = a - b;
            multiply = a * b;
            divide = a / b;
            modulus = a % b;

            Console.WriteLine ($"a = {a}; b = {b};");
            Console.WriteLine ("sum = " + sum);
            Console.WriteLine ("substract = " + substract);
            Console.WriteLine ("multiply = " + multiply);
            Console.WriteLine ("divide = " + divide);
            Console.WriteLine ("modulus = " + modulus);
        }
    }
}
