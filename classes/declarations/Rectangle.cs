// DERIVED CLASS EXAMPLE

using System;

namespace c_sharp_console_examples
{
    public class Rectangle : Shape
    {
        public override void Draw () 
        {
            Console.WriteLine ("The rectangle was drawn");
        }
    }
}