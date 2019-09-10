using System;
using System.Collections.Generic;

namespace c_sharp_console_examples
{
    class LinkedListExample
    {
        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public LinkedListExample ()
        {
            String output = "";
            LinkedList<int> numbers = new LinkedList<int> ();

            // Fills list
            for (int i = 0; i < 5; i++)
            {
                numbers.AddFirst (i);
                numbers.AddLast (i);
            }

            // Iterates
            Console.WriteLine ("Numbers in the list: ");
            for (LinkedListNode<int> node = numbers.First; node != null; node = node.Next)
            {
                output += $" {node.Value} ";
            }

            Console.WriteLine (output);

            // Put values based on first / last node
            numbers.AddAfter (numbers.First, -100);
            numbers.AddBefore (numbers.Last, 1200);

            // Iterates
            output = "";
            Console.WriteLine("\n List after changes: ");
            foreach (int n in numbers)
            {
                output += $" {n} ";
            }

            Console.WriteLine (output);

            // Removes first / last node
            numbers.RemoveFirst ();
            numbers.RemoveLast ();

            // Iterates in reverse sequence
            output = "";
            Console.WriteLine("\n List in reverse sequence : ");
            for (LinkedListNode<int> node = numbers.Last; node != null; node = node.Previous)
            {
                output += $" {node.Value} ";
            }

            Console.WriteLine (output);
        }
    }
}