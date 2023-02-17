namespace ImplimentingLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericSingleLinkedList<int> list = new GenericSingleLinkedList<int>();

            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);
            list.AddFirst(0);
            list.AddAfter(111, 1);

            Console.WriteLine(list.Contains(3));

            list.DisplayData();

            list.RemoveLast();
            list.RemoveNode(4);
            list.RemoveFirst();
            list.DisplayData();

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