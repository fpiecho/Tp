using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP0.Classes
{
    public class DataNode : INode
    {
        private object data;
        private INode nextNode = new EmptyNode();

        public DataNode(object data)
        {
            this.data = data;
        }

        public int getSize()
        {
            return nextNode.getSize() + 1;
        }

        public object getData()
        {
            return this.data;
        }

        public INode Add(object data)
        {
            this.nextNode = this.nextNode.Add(data);
            return this;
        }

        public INode getLinkedNode()
        {
            return this.nextNode;
        }
    }
}
