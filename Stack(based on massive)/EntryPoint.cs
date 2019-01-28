using Stack_based_on_massive_;
using System;

namespace Stack_based_on_massive
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Stack<string> stack = new Stack<string>(8);

                stack.Push("Kate");
                stack.Push("Sam");
                stack.Push("Alice");
                stack.Push("Tom");

                var head = stack.Pop();
                Console.WriteLine(head);

                head = stack.Peek();
                Console.WriteLine(head);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
