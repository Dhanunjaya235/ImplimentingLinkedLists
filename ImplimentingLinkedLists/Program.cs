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
        }
    }
}