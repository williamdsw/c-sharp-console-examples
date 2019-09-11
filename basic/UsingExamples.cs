using System;
using System.IO;
using System.Text;

namespace c_sharp_console_examples
{
    public class UsingExamples
    {
        private const string filePath = "my-file.txt";

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public UsingExamples ()
        {
            CreateFile (filePath);
            ReadFile (filePath);
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void CreateFile (string filePath)
        {
            // Data
            StringBuilder builder = new StringBuilder();
            builder.AppendLine ("London Bridge is falling down,");
            builder.AppendLine ("Falling down, falling down.");
            builder.AppendLine ("London Bridge is falling down,");
            builder.AppendLine ("My fair lady");

            using (StreamWriter writer = new StreamWriter (filePath))
            {
                writer.WriteLine (builder);
            }

            // Checks
            if (File.Exists (filePath))
            {
                Console.WriteLine ("File created successfully");
            }
            else 
            {
                Console.WriteLine ("Error on file's creation");
            }
        }

        private void ReadFile (string filePath)
        {
            // Checks
            if (!File.Exists (filePath))
            {
                Console.WriteLine ("File doesn't exist.");
                return;
            }

            // Reads data
            String content = string.Empty;
            using (TextReader reader = new StreamReader (filePath))
            {
                content = reader.ReadToEnd ();
            }

            Console.WriteLine (content);
            File.Delete (filePath);
        }
    }
}
