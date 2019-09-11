// INTERFACE DERIVED EXAMPLE

using System;

namespace c_sharp_console_examples
{
    public class Earth : IPlanet
    {
        public void Rotate ()
        {
            Console.WriteLine ("The Earth is rotating...");
        }
    }
}