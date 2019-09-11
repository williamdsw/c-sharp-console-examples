
namespace c_sharp_console_examples
{
    public class StaticConstructor
    {
        //-----------------------------------------------------------------------//
        // PROPERTIES

        public static int X { get; private set; }
        public static int Y { get; private set; }
        public static int Z { get; private set; }
        
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        static StaticConstructor ()
        {
            X = 10;
            Y = 0;
            Z = 3;
        }
    }
}