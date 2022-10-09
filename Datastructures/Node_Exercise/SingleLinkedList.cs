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
            _counter++; // anderst gemacht, weil bereits inhalte in node sind, sonst so machen
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
            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = head;
            head = newNode;
        }

        public void insert_After(int newElement, int position)
        {
            Node newNode = new Node(0);
            newNode.data = newElement;
            newNode.next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be >= 1.");
            }
            else if (position == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {

                Node n = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (n != null)
                    {
                        n = n.next;
                    }
                }

                if (n != null)
                {
                    newNode.next = n.next;
                    n.next = newNode;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
        }

        public Node GetHead()
        {
            return head;
        }

        public void getNode (int argData)
        {
            Node n = head;
            int value = 0;
            if (n != null)
            {
                while (n != null) 
                { 
                    if (n.data == argData)
                    {
                        value++;
                        break;
                    }
                    n = n.next;
                }
                if (value == 1)
                {
                    Console.WriteLine(argData);
                }
                else
                {
                    Console.WriteLine(argData + " is not found in the list.");
                }
            }
            else
            {
                Console.Write("Node is empty");
            }
        }

        public void DeleteNode(Node argNode)
        {
            if (head == null)
            {
                return;
            }

            if (head.data == argNode.data)
            {
                head = head.next;
                return;
            }

            Node n = head;
            while (n.next != null)
            {
                if (n.next.data == argNode.data)
                {
                    n.next = n.next.next;
                    break;
                }
                n = n.next;
            }
        }
    }
}