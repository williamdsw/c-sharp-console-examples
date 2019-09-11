
namespace c_sharp_console_examples
{
    public class Indexers
    {
        private string[] names = new string[10];

        // INDEXER
        public string this[int index]
        {
            get 
            {
                // Checks
                if (index < 0 || index >= names.Length) { return string.Empty; }
                return names[index]; 
            }

            set 
            { 
                // Checks
                if (index < 0 || index >= names.Length) { index = 0; }
                names[index] = value; 
            }
        }
    }
}