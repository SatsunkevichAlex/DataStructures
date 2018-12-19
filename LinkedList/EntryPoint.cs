using System;

namespace DataStructures
{
    class EntryPoint
    {
        static void Main()
        {
            LinkedListSample();
        }

        public static void LinkedListSample()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.Add("Tom");
            linkedList.Add("Alice");
            linkedList.Add("Bob");
            linkedList.Add("Sam");


            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("________________________________");

            var isPresent = linkedList.Contains("Sam");
            Console.WriteLine(isPresent ? "'Sam' exist in list" : "'Sam' does not exist in list");
            Console.WriteLine("________________________________");

            linkedList.AppendFirst("Bill");
            Console.WriteLine("Append 'Bill' to list");

            Console.WriteLine("________________________________");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________________________________"); 
            Console.WriteLine("Remove 'Tom' from list");
            linkedList.Remove("Tom");

            Console.WriteLine("________________________________");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("________________________________");
            Console.WriteLine(linkedList.IsEmpty ? "List empty" : "List isn't empty");
            Console.WriteLine("________________________________");
        }
    }
}
