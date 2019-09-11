using System;

namespace c_sharp_console_examples
{
    public class IndexerUse
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public IndexerUse ()
        {
            // Data
            Indexers indexers = new Indexers ();
            indexers[0] = "John";
            indexers[1] = "Jack";
            indexers[2] = "Bruce";
            indexers[3] = "Tom";
            indexers[4] = "Tim";

            // Output
            Console.WriteLine ("First Indexer Name: {0}", indexers[0]);
        }
    }
}