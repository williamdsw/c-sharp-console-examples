using System;

namespace c_sharp_console_examples
{
    public class DestructorClass
    {
        // CONSTRUTOR
        public DestructorClass ()
        {
            Console.WriteLine ("Writing from the class's constructor.");
        }

        // DESTRUCTOR
        ~DestructorClass ()
        {
            Console.WriteLine ("Writing from the class's destructor");
        }
    }
}