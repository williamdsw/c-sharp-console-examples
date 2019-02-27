using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class ArrayParameters
    {
        public ArrayParameters ()
        {
            // "fills" the black hole
            BlackHole ("String", 1, 1.0, 105.22F, true, new Object (), 1.45D);

            // sums with diverses parameters
            int firstSum = sum ();
            int secondSum = sum (new Random().Next(), new Random().Next());
            int thirdSum = sum (10, -1, 554);
            int fourthSum = sum (-15, -30, 200, 4562, -3000);

            Console.WriteLine (firstSum);
            Console.WriteLine (secondSum);
            Console.WriteLine (thirdSum);
            Console.WriteLine (fourthSum);
        }

        public int sum (params int[] values)
        {
            int result = 0;

            if (values.Length > 1)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    result += values[i];
                }
            }

            return result;
        }

        public void BlackHole (params object[] objects)
        {
            if (objects == null)
            {
                Console.WriteLine ("No parameters...");
            }
            else
            {
                foreach (object obj in objects)
                {
                    Console.WriteLine (obj);
                }
            }
        }
    }
}
