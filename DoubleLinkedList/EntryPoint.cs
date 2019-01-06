using System;

namespace DoubleLinkedList
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<string> linkedList = new DoubleLinkedList<string>();

            linkedList.Add("Bob");
            linkedList.Add("Bill");
            linkedList.AddFirst("Kate");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            linkedList.Remove("Bill");

            foreach(var t in linkedList.BackEnumerator())
            {
                Console.WriteLine(t);
            }
        }
    }
}
