using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP0.Classes
{
    public interface INode
    {
        object getData();

        int getSize();

        INode Add(object data);

        INode getLinkedNode();
    }
}
