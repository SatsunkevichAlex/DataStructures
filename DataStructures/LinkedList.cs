using System.Collections.Generic;

namespace DataStructures
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;

        //Add element
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (_head == null)
                _head = node;
            else
                _tail.Next = node;
            _tail = node;

            _count++;
        }

        //Remove element
        public bool Remove(T data)
        {
            Node<T> current = _head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    //If node in the middle or in the end
                    if (previous != null)
                    {
                        //Remove node 'current', now 'previous' reference not on 'current', but on 'current.Next'
                        previous.Next = current.Next;

                        //If 'current.Next' is not set, so current node is the last node,
                        //change variable 'tail'
                        if (current.Next == null)
                            _tail = previous;
                    }
                    else
                    {
                        //If delete first element
                        //reset value 'head'
                        _head = _head.Next;

                        //If after remove list empty, drop tail
                        if (_head == null)
                            _tail = null;
                    }

                    _count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }
    }
}
