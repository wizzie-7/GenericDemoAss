using System;
using System.Collections.Generic;

namespace GenericDemoAss
{
    class GenericQueueDemo
    {
        static void Main(string[] args)
        {
            Queue<char> GQ = new Queue<char>();
            GQ.Enqueue('A');
            GQ.Enqueue('B');
            GQ.Enqueue('C');
            GQ.Enqueue('D');
            GQ.Enqueue('E');

            Console.WriteLine("Numbers of Items in GenricQueue: " + GQ.Count);

            Console.WriteLine("******Generec Queue******");
            foreach(var v in GQ)
            {
                Console.WriteLine("\t{0}",v);
            }

            Console.WriteLine("**************************");
            //char FI = GQ.Peek();
            Console.WriteLine("First Item in Queue: " + GQ.Peek());
            
            GQ.Dequeue();
            
            Console.WriteLine("Numbers of Items in GenricQueue After deleting Item: " + GQ.Count);

            Console.WriteLine("******Generec Queue After Deleting Item******");
            foreach (var v in GQ)
            {
                Console.WriteLine("\t{0}", v);
            }

            Console.WriteLine("**********************************************");

            Console.WriteLine("First Item in Queue After Deleting Item: " + GQ.Peek());
        }
    }
}
