using System;

namespace c_sharp_console_examples
{
    class NullableTypes
    {
        private int? myInteger = null;
        private long? myLong = null;
        private float? myFloat = null;
        private double? myDouble = null;
        private bool? myBool = null;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public NullableTypes ()
        {
            try
            {
                // Checks and define values
                myLong = (myLong.HasValue ? myLong : 100L);
                myFloat = (myFloat.HasValue ? myFloat : 0.111F);
                myDouble = (myDouble.HasValue ? myDouble : new Random ().NextDouble ());

                // Shows data
                Console.WriteLine ("My nullable integer has a value ? = " + myInteger.HasValue);
                Console.WriteLine ("My nullable long = " + myLong);
                Console.WriteLine ("My nullable float = " + myFloat);
                Console.WriteLine ("My nullable double = " + myDouble);
                Console.WriteLine ("My nullable boolean = " + myBool.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}