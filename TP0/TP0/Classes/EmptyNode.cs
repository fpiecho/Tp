using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP0.Classes
{
    public class EmptyNode : INode
    {
        public EmptyNode()
        { }

        public int getSize()
        {
            return 0;
        }

        public object getData()
        {
            throw new InvalidOperationException();
        }

        public INode Add(object data)
        {
            return new DataNode(data);
        }

        public INode getLinkedNode()
        {
            throw new InvalidOperationException();
        }
    }
}
