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
        int _counter;

        public void insertLast(int newElement)
        {
            Node node = new Node(newElement, null);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = node;
            }
        }

        public int count()
        {
            Node n = head;
            int i = 0;
            while (n != null)
            {
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

        public void insert_First(int newElement)
        {
            Node newNode = new Node(newElement, null);
            newNode.data = newElement;
            newNode.next = head;
            head = newNode;
        }

        public void insert_After(int argNewNode, int argPreviousNode)
        {

        }

       public Node GetNode(int argData)
        {
            {
                Node temp = new Node(0, null);
                temp = this.head;

                if (temp != null)
                {

                    while (temp != null)
                    {
                        if (temp.data == argData)
                        {
                            return temp;
                        }
                        temp = temp.next;
                    }
                }
                return null;
            }
        }

        public bool DeleteNode(int argNode)
        {
            Node currentNode = head;
            Node previousNode = head;
            while (currentNode!.Equals(argNode))
            {
                if (currentNode.next == null)
                {
                    return false;
                }
                previousNode = currentNode;
                currentNode = currentNode.next;
            }
            previousNode.next = currentNode.next;
            return true;
        }
    }
}