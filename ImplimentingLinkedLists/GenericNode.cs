namespace ImplimentingLinkedLists
{
    internal class GenericNode<T>
    {
        public T data;
        public GenericNode<T>? next;

        public GenericNode()
        {

            next = null;
        }

        public GenericNode(T data)
        {
            this.data = data;
            next = null;
        }
    }
}
