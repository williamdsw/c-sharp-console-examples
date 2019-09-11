using System;

namespace c_sharp_console_examples
{
    public class VariableTypes
    {
        private int myInteger = 10;
        private long myLong = 300L;
        private float myFloat = 10.5F;
        private double myDouble = 100.44;
        private decimal myDecimal = 0.352M;
        private string myString = "String example";
        private char myCharacter = 'x';
        private bool myBoolean = true;

        // Wrappers
        private Int16 otherInteger = 33;
        private Double otherDouble = 22.453;
        private Decimal otherDecimal = 10.99M;
        private String otherString = "String wrapper";
        private Char otherCharacter = 'z';
        private Boolean otherBoolean = false;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public VariableTypes ()
        {
            // Shows data
            Console.WriteLine ("myInteger : " + myInteger);
            Console.WriteLine ("myLong : " + myLong);
            Console.WriteLine ("myFloat : " + myFloat);
            Console.WriteLine ("myDouble : " + myDouble);
            Console.WriteLine ("myDecimal : " + myDecimal);
            Console.WriteLine ("myString : " + myString);
            Console.WriteLine ("myCharacter : " + myCharacter);
            Console.WriteLine ("myBoolean : " + myBoolean);
            Console.WriteLine ("otherInteger : " + otherInteger);
            Console.WriteLine ("otherDouble : " + otherDouble);
            Console.WriteLine ("otherDecimal : " + otherDecimal);
            Console.WriteLine ("otherString : " + otherString);
            Console.WriteLine ("otherCharacter : " + otherCharacter);
            Console.WriteLine ("otherBoolean : " + otherBoolean);
        }
    }
}