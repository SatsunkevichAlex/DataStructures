using System;

namespace Deque
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Deque<string> usersDeck = new Deque<string>();
            usersDeck.AddFirst("Alice");
            usersDeck.AddLast("Kate");
            usersDeck.AddLast("Tom");

            foreach (string s in usersDeck)
            {
                Console.WriteLine(s);
            }

            string removedItem = usersDeck.RemoveFirst();
            Console.WriteLine("\n Deleted: {0} \n", removedItem);

            foreach (string s in usersDeck)
                Console.WriteLine(s);
        }
    }
}
