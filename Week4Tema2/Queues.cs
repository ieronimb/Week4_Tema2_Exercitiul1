using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week4Tema2
{
    public class Queues
    //M-am inspirat din https://www.lynda.com/C-tutorials/Queue-explained/604241/636313-4.html

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

            if (rear == maxSize - 1)
            {
                rear = -1;
            }
            rear++;
            MyQueue[rear] = j;
            items++;

        }

        public long Remove()
        {
            long temp = MyQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }
            return temp;
        }
        public long peekFront()
        {
            return MyQueue[front];
        } 

        public void View()
        {
            Console.Write("[");
            for (int i = 0; i < MyQueue.Length; i++)
            {
                Console.Write(MyQueue[i] + " ");
            }
            Console.WriteLine("]");
        }
    }

}
