using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class ParametersRefOut
    {
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
            Initializate (out otherValue);
            Console.WriteLine ("Value initializated using OUT = " + otherValue);
        }

        private void Increment (int value)
        {
            value++;
        }

        private void Increment (ref int value)
        {
            value++;
        }

        private void Initializate (out int value)
        {
            value = 10;
        }
    }
}
