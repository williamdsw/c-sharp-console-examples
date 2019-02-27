using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleExamples
{
    class Person
    {
        private String firstName;
        private String lastName;
        private int age;
        private double height;
        private double weight;

        public Person () { }

        public String getFirstName ()
        {
            return this.firstName;
        }

        public void setFirstName (String value)
        {
            this.firstName = value;
        }

        public String getLastName ()
        {
            return this.lastName;
        }

        public void setLastName (String value)
        {
            this.lastName = value;
        }

        public int getAge ()
        {
            return this.age;
        }

        public void setAge (int value)
        {
            this.age = value;
        }

        public double getHeight ()
        {
            return this.height;
        }

        public void setHeight (double value)
        {
            this.height = value;
        }

        public double getWeight()
        {
            return this.weight;
        }

        public void setWeight (double value)
        {
            this.weight = value;
        }

        public String getFullName ()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}