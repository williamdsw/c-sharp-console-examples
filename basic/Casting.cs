using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class Casting
    {
        private int myInteger = 543;
        private double myDouble = 134.56;
        private string myString = "1534";
        private Object myObject;

        public Casting ()
        {
            int otherInteger = int.Parse (myString);
            double otherDouble = (double) otherInteger;
            myObject = myString;
            String otherString = myObject as String;
            bool isTypeString = myObject is String;

            Console.WriteLine ("My Integer = " + myInteger);
            Console.WriteLine ("My Double = " + myDouble);
            Console.WriteLine ("My String = " + myString);
            Console.WriteLine ("My Other Integer = " + otherInteger);
            Console.WriteLine ("My Other Double = " + otherDouble);
            Console.WriteLine ("My Object = " + myObject);
            Console.WriteLine ("My Object is an String ?  = " + isTypeString);
            Console.WriteLine ("My Other String = " + otherString);
        }
    }
}
