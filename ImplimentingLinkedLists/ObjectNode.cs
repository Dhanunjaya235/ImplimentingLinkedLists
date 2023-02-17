using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplimentingLinkedLists
{
    internal class ObjectNode
    {
        internal object data;
        internal ObjectNode? next;

        public ObjectNode()
        {
            next = null;
        }
        public ObjectNode(object data)
        {
            this.data = data;
            next = null;
        }
    }


}
