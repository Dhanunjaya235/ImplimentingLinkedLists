namespace ImplimentingLinkedLists
{
    internal class Node
    {
        internal int data;
        internal Node? next;

        public Node()
        {
            next = null;
        }
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
