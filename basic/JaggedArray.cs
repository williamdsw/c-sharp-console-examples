using System;

namespace c_sharp_console_examples
{
    public class JaggedArray 
    {
        // Array inside another array
        private int[][] myJaggedArray = 
        {
            new int[] {1},
            new int[] {1, 2},
            new int[] {1, 2, 3},
            new int[] {1, 2, 3, 4},
            new int[] {1, 2, 3, 4, 5}
        };

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public JaggedArray ()
        {
            for (int i = 0; i < myJaggedArray.Length; i++)
            {
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    string output = " {0} ° array. Index: {1} - Value: {2} ";
                    output = string.Format (output, (i + 1), j, myJaggedArray[i][j]);
                    Console.WriteLine (output);
                }
            }
        }
    }
}