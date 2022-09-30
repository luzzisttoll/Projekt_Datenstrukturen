using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class SingleLinkedList
    {
        public Node head;
       

        public void insert (int newElement)
        {
            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = null;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }

                n.next = newNode;
            }
        }

        public int count()
        {
            Node n = head;
            int i = 0;
            while (n != null) {
                i++;
                n = n.next;
            }
            Console.WriteLine("Die Anzahl beträgt " + i + ";");
            return i;
        }

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + ", ");
                n = n.next;
            }
        }
    }
}
