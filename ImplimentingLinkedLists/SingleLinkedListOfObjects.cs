using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplimentingLinkedLists
{
    internal class SingleLinkedListOfObjects
    {
        private ObjectNode? head;

        public SingleLinkedListOfObjects()
        {
            head = null;
        }

        public void AddNode(object data)
        {
            ObjectNode newNode = new ObjectNode(data);

            if (head == null) head = newNode;
            else
            {
                ObjectNode temp = new ObjectNode();
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void DisplayData()
        {
            ObjectNode? temp = this.head;
            if (temp != null)
            {
                Console.WriteLine("The Single Linked List Contains Data : ");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
            else
                Console.WriteLine("The Single Linked List is Empty");
        }

        public bool Contains(object data)
        {
            ObjectNode? temp = new ObjectNode();
            temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data.Equals(data))
                    {
                        return true;
                    }
                    temp = temp.next;
                }
                return false;
            }
            else
                return false;
        }

        public void RemoveFirst()
        {
            ObjectNode temp = head.next;

            this.head = temp;
        }

        public void RemoveLast()
        {
            if (head != null)
            {
                ObjectNode temp = head;
                if (temp.next != null)
                {
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                }
                temp.next = null;
            }
        }

        public void RemoveNode(object data)
        {
            ObjectNode temp = head;
            if (temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null)
            {
                var d = temp.next.data;
                if (d.Equals(data))
                {
                    temp.next = temp.next.next;
                    break;
                }
                temp = temp.next;
            }

        }

        public void Clear()
        {
            this.head = null;
        }

        public void AddAfter(object checkData, object data)
        {
            if (head == null)
            {
                this.AddNode(data);
            }
            else
            {
                ObjectNode temp = head;
                while (temp != null)
                {
                    if (temp.data.Equals(checkData))
                    {
                        ObjectNode newnode = new ObjectNode(data);
                        ObjectNode t = temp.next;
                        temp.next = newnode;
                        newnode.next = t;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        public void AddFirst(object data)
        {
            if (head == null) this.AddNode(data);
            else
            {
                ObjectNode newNode = new ObjectNode(data);
                newNode.next = head;
                head = newNode;
            }
        }
    }


}
