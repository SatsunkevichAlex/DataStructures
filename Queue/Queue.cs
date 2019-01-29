using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public bool IsEmpty { get { return count == 0; } }

        public int Count { get { return count; } }

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;

            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;

            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();

            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;

            while (data != null)
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
            Node<T> current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
