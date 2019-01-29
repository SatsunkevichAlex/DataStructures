using System;

namespace Queue
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            foreach (string item in queue)
                Console.WriteLine(item);
            Console.WriteLine();

            string firstItem = queue.Dequeue();
            Console.WriteLine($"Extracted item: {firstItem}");
            Console.WriteLine();

            foreach (string item in queue)
                Console.WriteLine(item);
        }
    }
}
