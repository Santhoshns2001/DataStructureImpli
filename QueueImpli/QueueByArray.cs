using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndDataStructureApril0104.QueueImpli
{
    internal class QueueByArray
    {
        Object[] queue;
        int size;
        int front, rear = -1;

       public  QueueByArray(int size)
        {
            this.size = size;
            queue=new object[size];
            front = rear = 0;
        }



        public void Enque(Object data)
        {
            if(rear== size-1)
            {
                Console.WriteLine("queue is overflow");
                return;
            }
            else if(front==-1 && rear==-1)
            {
                front = rear = 0;
                queue[rear] = data;
            }

            else
            {
                rear++;
                queue[rear] = data;
            }
        }

        public void Deque()
        {

          
            if (rear == -1 && rear == -1)
            {
                Console.WriteLine("the queue is empty or underflow ");
            }

            //else if (front == rear)
            //{
            //    front = rear = -1;
            //}

            //else {
            //    Console.WriteLine("the dequedelement is " + queue[front]);
            //    front++;
            //}

            Object data = queue[front++];
            if (front > rear)
                rear = front = -1;
            Console.WriteLine(data);



        }

        public void Peek()
        {
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("queue is empty");
                return;
            }


            Console.WriteLine("the first element in queue is "+queue[front]);
        }

        public void Display()
        {
            if(front==-1 && rear==-1)
            {
                Console.WriteLine("queue is empty");
                return;
            }

            for(int i=front;i<rear+1;i++)
            {
                Console.Write(queue[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
