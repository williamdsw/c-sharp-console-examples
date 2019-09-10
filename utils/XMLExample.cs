using System;
using System.IO;
using System.Text;
using System.Xml;

namespace c_sharp_console_examples
{
    class XMLExample
    {
        private static string filePath = "movies.xml";

        //-------------------------------------------------------------------------------//
        // CONSTRUCTOR

        public XMLExample ()
        {
            Create (filePath);
            Read (filePath);
        }

        //-------------------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private void Create (string path)
        {
            try
            {
                using (XmlWriter writer = XmlWriter.Create (path))
                {
                    // <?xml version="1.0" encoding="utf-8"?>
                    writer.WriteStartDocument ();
                    writer.WriteComment ("example of comment");

                    // Root tag
                    writer.WriteStartElement ("movies");

                    // Sub tags / attributes # 1
                    writer.WriteStartElement ("movie");
                    writer.WriteAttributeString("id", "1");
                    writer.WriteElementString ("title", "Die Hard");
                    writer.WriteElementString ("genre", "Action Thriller");
                    writer.WriteElementString ("year", "1988");
                    writer.WriteEndElement ();

                    // Sub tags / attributes # 2
                    writer.WriteStartElement("movie");
                    writer.WriteAttributeString("id", "2");
                    writer.WriteElementString("title", "The Exorcist");
                    writer.WriteElementString("genre", "Supernatural Horror");
                    writer.WriteElementString("year", "1971");
                    writer.WriteEndElement();

                    // Sub tags / attributes # 3
                    writer.WriteStartElement("movie");
                    writer.WriteAttributeString("id", "3");
                    writer.WriteElementString("title", "Batman Begins");
                    writer.WriteElementString("genre", "Superhero");
                    writer.WriteElementString("year", "2005");
                    writer.WriteEndElement();

                    // Closes root tag
                    writer.WriteFullEndElement();
                }

                Console.WriteLine ("XML file created...");
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }

        private void CheckFile (string path)
        {
            // Checks and cancels
            if (!File.Exists (path))
            {
                Console.WriteLine ("XML file doesn't exist.");
                return;
            }
            else if (!path.Contains (".xml"))
            {
                Console.WriteLine ("File isn't an XML");
                return;
            }
        }

        private void Read (string path)
        {
            try
            {
                CheckFile (path);

                StringBuilder output = new StringBuilder ();

                using (XmlReader reader = XmlReader.Create (new StreamReader (path)))
                {
                    while (reader.Read ())
                    {
                        // Reads data based on node type
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Attribute:
                            {
                                output.Append (string.Concat ("\"", reader.Name, "\"", "=", reader.Value));
                                break;
                            }

                            case XmlNodeType.Element:
                            {
                                output.Append (string.Concat ("\n", "<", reader.Name, ">"));
                                break;
                            }
                            
                            case XmlNodeType.Text:
                            {
                                output.Append (reader.Value);
                                break;
                            }

                            case XmlNodeType.EndElement:
                            {
                                output.Append (string.Concat ("</", reader.Name, ">"));
                                break;
                            }

                            default: { break; }
                        }
                    }
                }

                Console.WriteLine (output);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}
