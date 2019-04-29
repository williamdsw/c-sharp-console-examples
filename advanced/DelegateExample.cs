using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class DelegateExample
    {
        delegate void myDelegate ();

        public DelegateExample ()
        {
            /* New delegate and call */
            myDelegate del = new myDelegate (printRandomIntegers);
            del ();
        }

        private void printRandomIntegers ()
        {
            Console.WriteLine ("Random Integers between 0 and 100:");

            Random random = new Random ();

            /* Prints a number between 0 and 100 */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine (random.Next (100));
            }
        }
    }
}
