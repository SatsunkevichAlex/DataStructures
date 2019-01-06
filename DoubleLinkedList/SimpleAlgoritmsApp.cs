using System.Collections.Generic;
using System.Collections;

namespace DoubleLinkedList
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        private DoubleNode<T> _head;
        private DoubleNode<T> _tail;
        int _count;
        
        public void Add(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);

            if (_head == null)
                _head = node;
            else
            {
                _tail.Next = node;
                node.Previous = _tail;
            }

            _tail = node;
            _count++;
        }

        public void AddFirst(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            DoubleNode<T> temp = _head;
            node.Next = temp;
            _head = node;

            if (_count == 0)
                _tail = _head;
            else
                temp.Previous = node;

            _count++;
        }

        public bool Remove(T data)
        {
            DoubleNode<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }

            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    _tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    _head = current.Next;
                }
                _count--;
                return true;
            }
            return false;
        }

        public int Count { get { return _count; } }
        public bool IsEmpty { get { return _count == 0; } }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public bool Contains(T data)
        {
            DoubleNode<T> current = _head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoubleNode<T> current = _tail;

            while(current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}
