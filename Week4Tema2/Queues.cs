using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week4Tema2
{
    public class Queues
    {

        private int maxSize;
        private long[] MyQueue;
        private int front;
        private int rear;
        private int items;

        public Queues(int size)
        {
            maxSize = size;
            MyQueue = new long[size];
            front = 0;
            rear = -1;
            items = 0;
        }
        public void insert(long j)
        {
            if(isFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (rear == maxSize - 1)
                {
                    rear = -1;
                }
                rear++;
                MyQueue[rear] = j;
                items++;
            }
            
        }

        public long Remove()
        {
            long temp = MyQueue[front];
            front++;
            if (front==maxSize)
            {
                front = 0;
            }
            return temp;
        }
        public long peekFront()
        {
            return MyQueue[front];
        }

        public bool isEmpty()
        {
            return (items == 0);
        }

        private bool isFull()
        {
            return (items == maxSize);
        }

        public void View()
        {
            Console.Write("[");
            for (int i = 0; i < MyQueue.Length; i++)
            {
                Console.Write(MyQueue[i]+ " ");
            }
            Console.WriteLine("]");
        }
    }

}
