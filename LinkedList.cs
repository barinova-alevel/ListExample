using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class LinkedList : ILinkedList
    {
        public Node Head { get; private set; }
        public Node Tail { get; private set; }

        public void Add(Node node)
        {
            if (Head == null)
                Head = node;
            if (Tail == null)
                Tail = node;
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }


        public void OutputAllNodes()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }

        public void Remove(int value)
        {
            Node temp = Head;
            Node prevTemp = null;
            while (temp != null)
            {
                if (temp.Value == value && prevTemp== null)
                {
                    Head = temp.Next;
                    break;
                }

                if (prevTemp != null && temp.Value == value)
                {
                    prevTemp.Next = temp.Next;
                    if (temp.Next == null)
                    {
                        Tail = prevTemp;
                    }
                    break;
                } 


                prevTemp = temp;
                temp = temp.Next;

            }
        }
    }
}
