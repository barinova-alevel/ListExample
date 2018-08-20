using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public interface ILinkedList
    {
        Node Head { get; }
        Node Tail { get;  }
        void Add(Node node);
        void Remove(int Value);
        void OutputAllNodes();
    }
}
