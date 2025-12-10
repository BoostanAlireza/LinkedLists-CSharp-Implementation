using System;


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
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(60);
            // list.reverse();
            list.Print();
            // Console.WriteLine(list.getKthFromTheEnd(0));
            // list.printMiddle();
            // Console.WriteLine(list.hasLoop());
            // list.DeleteFirst();
            // list.Print();

            // list.DeleteLast();
            // list.Print();   

            // Console.WriteLine(list.Contains(10));   
            // Console.WriteLine(list.IndexOf(20));

            // var array = list.ToArray();
            // Console.WriteLine(string.Join(", ", array));

        }
    }
}
