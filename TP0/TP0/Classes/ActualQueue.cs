using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP0.Classes
{
    public class ActualQueue : IQueue
    {
        private INode firstNode;

        public ActualQueue()
        {
            this.firstNode = new EmptyNode();
        }

        public int Size { get { return this.firstNode.getSize(); } }

        public bool IsEmpty { get { return this.firstNode.getSize() == 0; } }

        public object Top { get { return this.firstNode.getData(); } }

        public void Add(object item)
        {
            this.firstNode = firstNode.Add(item);
        }

        public void Remove()
        {
            this.firstNode = this.firstNode.getLinkedNode();
        }
    }
}
