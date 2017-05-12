using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood_iterator_eng_2.CustomCollections
{
    class CustomLinkedList<T> : ICustomCollection<T>
    {
        private LinkedNode<T> head;
        private LinkedNode<T> tail;
        private int length = 0;

        public void Add(T value)
        {
            LinkedNode<T> newNode = new LinkedNode<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = head;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
            length++;
        }

        public T Get(int n)
        {
            if (n >= length || n < 0)
                return default(T);
                
            var temp = head;
            while (n > 0)
            {
                temp = temp.Next;
                n--;
            }

            return temp.Value;
        }

        public int Size
        {
            get
            {
                return length;
            }
        }
    }
}
