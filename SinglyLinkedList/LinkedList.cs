using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class LinkedList
    {

        public class Node
        {
            public object data;
            public Node next;

            public Node(object data)
            {
                this.data = data;
            }
        }

        Node head;


        public void InsertData(object data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return;
            }
            //  Console.WriteLine("Insert method");
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = n;

        }


        public void InsertFirst(object data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }

            n.next = head;
            head = n;

        }

        public void InsertLast(object data)
        {
            Node n = new Node(data);
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = n;
        }

        public void InsertParticular(object data, int ind)
        {
            Node n = new Node(data);
            if (ind == 0)
                InsertFirst(data);

            Node temp = head;

            while (temp != null && ind > 1)
            {
                temp = temp.next;
                ind--;
            }

            n.next = temp.next;
            temp.next = n;


        }
        public object DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return null;
            }

            object data = head.data;
            head = head.next;
            return data;



        }

        public object DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return null;
            }

            Node temp = head;
            Node prev = null;
            while (temp.next != null)
            {
                temp = temp.next;
                prev = temp;
            }

            object data = temp.data;

            prev.next.data = null;



            return data;

        }

        public object DeleteParticular(int ind)
        {
            if (ind == 0)
                DeleteFirst();

            if (head == null)
                Console.WriteLine("list is empty");

            Node temp = head;

            while (temp.next != null && ind > 1)
            {
                temp = temp.next;
                ind--;
            }

            object data = temp.next.data;
            temp.next = temp.next.next;
            temp.next.next = null;
            return data;



        }

        public void Display()
        {
            // Console.WriteLine("Display method");
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data);


                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;
            }
            Console.WriteLine();
        }


    }
}
