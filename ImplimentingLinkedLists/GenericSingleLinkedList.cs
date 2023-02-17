using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplimentingLinkedLists
{
    internal class GenericSingleLinkedList<T>
    {
        private GenericNode<T>? head;

        public GenericSingleLinkedList()
        {
            head = null;
        }

        public void AddNode(T value)
        {
            GenericNode<T> node = new GenericNode<T>(value);
            if (head == null) head = node;
            else
            {
                GenericNode<T> temp = new GenericNode<T>();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void DisplayData()
        {
            if (head == null)
            {
                Console.WriteLine("The single linked list is empty");
                return;
            }
            GenericNode<T> node = head;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void AddFirst(T value)
        {
            GenericNode<T> node = new GenericNode<T>(value);

            if (head == null) head = node;
            else
            {
                node.next = head;
                head = node;
            }
        }

        public void AddAfter(T data, T checkdata)
        {
            GenericNode<T> node = new GenericNode<T>(data);
            if (head == null) head = node;
            else
            {
                GenericNode<T> temp = head;
                while (temp != null)
                {
                    if (temp.data.Equals(checkdata))
                    {
                        GenericNode<T> temp2 = temp.next;
                        temp.next = node;
                        node.next = temp2;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        public bool Contains(T value)
        {
            if (head == null) return false;
            else
            {
                GenericNode<T> temp = head;
                while (temp != null)
                {
                    if (temp.data.Equals(value)) return true;
                    temp = temp.next;
                }
                return false;
            }
        }

        public void RemoveNode(T value)
        {
            GenericNode<T> temp = head;
            if (head == null) return;
            else if (temp.data.Equals(value))
            {
                head = temp.next;
            }
            else
            {
                while (temp != null)
                {
                    var d = temp.next.data;
                    if (d.Equals(value))
                    {
                        temp.next = temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        public void RemoveFirst()
        {
            if (head == null) return;
            else
            {
                GenericNode<T> temp = head;
                head = temp.next;
            }
        }

        public void RemoveLast()
        {
            if (head == null) return;
            else
            {
                GenericNode<T> temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }

        public void Clear()
        {
            head = null;
        }
    }

}
