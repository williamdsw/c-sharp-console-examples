using System;

namespace c_sharp_console_examples
{
    public class StaticConstructorUse
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public StaticConstructorUse ()
        {
            Console.WriteLine ("X = {0}, Y = {1}, Z = {2}", StaticConstructor.X, StaticConstructor.Y, StaticConstructor.Z);
        }
    }
}