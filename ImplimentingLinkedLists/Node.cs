using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
