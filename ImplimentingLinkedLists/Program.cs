namespace ImplimentingLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericSingleLinkedList<int> lists = new GenericSingleLinkedList<int>();

            lists.AddNode(1);
            lists.AddNode(2);
            lists.AddNode(3);
            lists.AddNode(4);
            lists.AddNode(5);
            lists.AddFirst(0);
            lists.AddAfter(111, 1);

            Console.WriteLine(lists.Contains(3));

            lists.DisplayData();

            lists.RemoveLast();
            lists.RemoveNode(4);
            lists.RemoveFirst();
            lists.DisplayData();

            SingleLinkedListOfObjects sll = new SingleLinkedListOfObjects();

            sll.AddNode(100);
            sll.AddNode("Dhanunjay");
            sll.AddFirst("Andavarapu");
            sll.AddAfter(100, 235);
            Console.WriteLine(sll.Contains(100));
            sll.DisplayData();

            sll.RemoveLast();
            sll.RemoveFirst();
            sll.RemoveNode(235);
            sll.DisplayData();

            sll.Clear();
            sll.DisplayData();


            SingleLinkedList list = new SingleLinkedList();

            list.AddNode(100);
            list.AddNode(200);
            list.AddNode(300);
            list.AddNode(400);
            list.AddNode(500);
            list.AddAfter(300, 700);
            list.AddFirst(1000);
            list.RemoveLast();
            list.DisplayData();

            list.RemoveNode(200);

            list.DisplayData();


        }
    }
}