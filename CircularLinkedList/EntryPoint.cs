using System;

namespace CircularLinkedList
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            CircularLinkedList<string> circularList = new CircularLinkedList<string>();

            circularList.Add("Tom");
            circularList.Add("Bob");
            circularList.Add("Alice");
            circularList.Add("Jack");

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            circularList.Remove("Bob");
            Console.WriteLine("\nAfter Delete:");
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
