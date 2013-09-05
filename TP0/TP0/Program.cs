using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP0.Classes;

namespace TP0
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue queue = new ActualQueue();
            queue.Add("1");
            queue.Add("2");
            queue.Add("3");
            queue.Add("4");

            object a = queue.Top;
            queue.Remove();
            int size = queue.Size;
            bool isEmpty = queue.IsEmpty;
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.Add("5");


        }
    }
}
