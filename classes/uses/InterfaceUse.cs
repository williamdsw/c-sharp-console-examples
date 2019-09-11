
namespace c_sharp_console_examples
{
    public class InterfaceUse
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public InterfaceUse ()
        {
            IPlanet earth = new Earth ();
            earth.Rotate ();
        }
    }
}