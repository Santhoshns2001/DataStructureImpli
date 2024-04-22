using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndDataStructureApril0104
{
    internal class LinkedList
    {

        public class Node
        {
            public Object data;
            public Node  next;

            public Node(Object data)
            {
                this.data = data;
            }
        }

        Node head;



        public void AddLast(Object data)
        {


            Node n = new Node(data);

            if(head==null)
            {
                head = n;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = n;
        }

        public void Display()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.Write(temp.data);

                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;

            }
            Console.WriteLine();
        }

    }
}
