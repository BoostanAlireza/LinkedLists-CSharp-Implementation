using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedLists.LinkedList();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            list.Print();
        }
    }
}
