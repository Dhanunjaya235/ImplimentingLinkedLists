using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplimentingLinkedLists
{
    internal class GenericConstraint<T> where T:struct
    {
        public T Value { get; set; }

    }
}
