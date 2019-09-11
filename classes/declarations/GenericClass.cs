// EXAMPLE OF GENERIC CLASS

namespace c_sharp_console_examples
{
    public class GenericClass<type>
    {
        private int currentIndex = 0;
        private type[] myArray = new type[100];

        //-----------------------------------------------------------------------//
        // PROPERTIES

        public int Length { get { return myArray.Length; }}

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        public void Push (type item)
        {
            myArray[currentIndex++] = item;
        }

        public type Pop ()
        {
            return myArray[--currentIndex];
        }

        public type Get (int index)
        {
            return myArray[index];
        }
    }
}