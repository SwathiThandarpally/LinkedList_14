using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_14
{
    internal class DeleteValueUC_9
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Delete(int value, int data)
        {
            Node node = head;
            while (node.data != value)
            {
                node = node.next;
            }
            node.next = node.next.next;
        }
        internal void size()
        {
            int a = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    a++;
                    temp = temp.next;
                }
                Console.WriteLine("Size Is:" + a);
            }
        }
    }
}
