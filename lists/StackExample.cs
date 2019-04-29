using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class StackExample
    {
        public StackExample()
        {
            string[] colorsArray = { "Black", "Red", "Yellow", "Blue", "Green", "Orange", "Pink", "Grey" };
            Stack<string> colors = new Stack<string> ();

            /* Adding */
            foreach (string color in colorsArray)
            {
                colors.Push (color);
                Console.WriteLine ("{0} has been pushed to Stack", color);
            }

            /* Remove values */
            Console.WriteLine ("");
            while (colors.Count > 0)
            {
                string color = colors.Pop ();
                Console.WriteLine("{0} has been poped from Stack", color);
            }
        }
    }
}