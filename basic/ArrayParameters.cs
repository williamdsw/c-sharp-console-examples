using System;

namespace c_sharp_console_examples
{
    public class ArrayParameters
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public ArrayParameters ()
        {
            // "fills" the black hole
            BlackHole ("String", 1, 1.0, 105.22F, true, new Object (), 1.45D);

            // Sum with diverses parameters
            int firstSum = Sum ();
            int secondSum = Sum (new Random().Next(), new Random().Next());
            int thirdSum = Sum (10, -1, 554);
            int fourthSum = Sum (-15, -30, 200, 4562, -3000);

            Console.WriteLine (firstSum);
            Console.WriteLine (secondSum);
            Console.WriteLine (thirdSum);
            Console.WriteLine (fourthSum);
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        // "params type[] field" = Array parameters
        private int Sum (params int[] values)
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

        // Array parameters with multiple types
        private void BlackHole (params object[] objects)
        {
            if (objects == null)
            {
                Console.WriteLine ("No parameters...");
            }
            else
            {
                foreach (object myObject in objects)
                {
                    Console.WriteLine (myObject);
                }
            }
        }
    }
}