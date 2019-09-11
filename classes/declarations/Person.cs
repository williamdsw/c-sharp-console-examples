
namespace c_sharp_console_examples
{
    public class Person
    {
        //-----------------------------------------------------------------------//
        // FIELDS

        private string firstName;
        private string lastName;
        private int age;
        private double height;
        private double weight;

        //-----------------------------------------------------------------------//
        // GETTERS / SETTERS

        public string GetFirstName ()
        {
            return this.firstName;
        }

        public void SetFirstName (string value)
        {
            this.firstName = value;
        }

        public string GetLastName ()
        {
            return this.lastName;
        }

        public void SetLastName (string value)
        {
            this.lastName = value;
        }

        public int GetAge ()
        {
            return this.age;
        }

        public void SetAge (int value)
        {
            this.age = value;
        }

        public double GetHeight ()
        {
            return this.height;
        }

        public void SetHeight (double value)
        {
            this.height = value;
        }

        public double GetWeight ()
        {
            return this.weight;
        }

        public void SetWeight (double value)
        {
            this.weight = value;
        }

        public string GetFullName ()
        {
            return string.Concat (this.firstName, " ", this.lastName);
        }
    }
}