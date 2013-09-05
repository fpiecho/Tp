using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP0.Classes
{
    public interface IQueue
    {
        int Size { get; }

        bool IsEmpty { get; }

        object Top { get; }

        void Add(object item);

        void Remove();
    }
}
