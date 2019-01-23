using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueWithStacks.Classes;

namespace que_with_stack
{ 
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Queue with stacks demo: \n");
        QueueWithStacks();
    }


    public static void QueueWithStacks()
    {
        //Create a queue
        Queue myQueue = new Queue(new StackAndQueue.Classes.Node(1));
        Console.WriteLine("Enqueuing 2 to the newly created queue...");
        myQueue.Enqueue(new StackAndQueue.Classes.Node(2));
        Console.WriteLine("Dequeuing 1 from the queue...");
        StackAndQueue.Classes.Node firstNode = myQueue.Dequeue();
        Console.WriteLine($"Value just dequeued: {firstNode.Value}");
        Console.WriteLine($"The queue's front should now be 2. It is: {myQueue.Front.Value}");
        Console.WriteLine($"The queue's rear should be 2. It is: {myQueue.Rear.Value}");
    }
}
}
