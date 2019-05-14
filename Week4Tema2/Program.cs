using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Week4Tema2
{
    class Program
    {
        public static void Main(string [] args)
        {
            Queues myQueue = new Queues(5);
            myQueue.insert(100);
            myQueue.insert(10);
            myQueue.insert(20);
            myQueue.insert(30);
            myQueue.View();           

            Console.WriteLine($"Front of queue is {myQueue.peekFront()} ");

            Console.WriteLine("About to remove item from queue");
            myQueue.Remove();
            Console.WriteLine($"Front of queue is {myQueue.peekFront()} ");
            Console.ReadLine();
        }

    }
}
