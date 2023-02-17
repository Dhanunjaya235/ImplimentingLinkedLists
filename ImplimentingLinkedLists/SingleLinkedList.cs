namespace ImplimentingLinkedLists
{
    internal class SingleLinkedList
    {
        private Node? head;

        public SingleLinkedList()
        {
            head = null;
        }

        public void AddNode(int data)
        {
            Node newNode = new Node(data);

            if (head == null) head = newNode;
            else
            {
                Node temp = new Node();
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
            Node? temp = this.head;
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

        public bool Contains(int data)
        {
            Node? temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data == data)
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
            Node temp = head.next;

            this.head = temp;
        }

        public void RemoveLast()
        {
            if (head != null)
            {
                Node temp = head;
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

        public void RemoveNode(int data)
        {
            Node temp = head;
            if (temp.data == data)
            {
                head = temp.next;
                return;
            }
            while (temp != null)
            {
                var d = temp.next.data;
                if (d == data)
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

        public void AddAfter(int checkData, int data)
        {
            if (head == null)
            {
                this.AddNode(data);
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == checkData)
                    {
                        Node newnode = new Node(data);
                        Node t = temp.next;
                        temp.next = newnode;
                        newnode.next = t;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        public void AddFirst(int data)
        {
            if (head == null) this.AddNode(data);
            else
            {
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
            }
        }
    }
}
