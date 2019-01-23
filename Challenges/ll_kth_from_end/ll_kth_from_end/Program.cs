using System;
using LinkedList.Classes;


namespace ll_kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LList testList = new LList(new Node(1));
            testList.Append(new Node(2));
            testList.Append(new Node(3));
            testList.Append(new Node(4));
            testList.Append(new Node(5));

            int testEnd = testList.KthFromEnd(4);
            Console.WriteLine("The fourth value from the end is " + testEnd);
            Console.ReadKey();



        }
    }

}
