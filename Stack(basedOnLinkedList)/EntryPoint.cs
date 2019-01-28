using System;

namespace Stack_basedOnLinkedList_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            NodeStack<string> stack = new NodeStack<string>();

            stack.Push("Tom");
            stack.Push("Alice");
            stack.Push("Bob");
            stack.Push("Kate");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            string header = stack.Peek();
            Console.WriteLine($"Head of the stack is: {header}");
            Console.WriteLine();

            header = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
