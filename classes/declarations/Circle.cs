// DERIVED CLASS EXAMPLE

using System;

namespace c_sharp_console_examples
{
    public class Circle : Shape
    {
        public override void Draw () 
        {
            Console.WriteLine ("The circle was drawn");
        }
    }
}