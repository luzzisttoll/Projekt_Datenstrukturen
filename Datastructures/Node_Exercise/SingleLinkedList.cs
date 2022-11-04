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

        public void InsertAfter(Node insertafter, int new_data)
        {
            if (insertafter == null)
            {
                Console.WriteLine("Diese Node existiert nicht");
                return;
            }
            Node new_node = new Node(new_data, null);
            new_node.next = insertafter.next;
            insertafter.next = new_node;
            return;
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

        public void SwitchNode(int firstNode, int secondNode)
        {

            // wenn gleich, dann passiert nichts
            if (firstNode == secondNode)
                return;

            //erste Node finden
            Node previousFirstNode = null;
            Node currentFirstNode = head;
            while (currentFirstNode != null && currentFirstNode.data != firstNode)
            {
                previousFirstNode = currentFirstNode;
                currentFirstNode = currentFirstNode.next;
            }

            //zweite Node finden
            Node previousSecondNode = null;
            Node currentSecondNode = head;
            while (currentSecondNode != null && currentSecondNode.data != secondNode)
            {
                previousSecondNode = currentSecondNode;
                currentSecondNode = currentSecondNode.next;
            }

            //wenn erste Node nicht head ist
            if (previousFirstNode != null)
            {
                previousFirstNode.next = currentSecondNode;
            }
            else
            {
                head = currentSecondNode;
            }

            //wenn zweite Node nicht head ist
            if (previousSecondNode != null)
            {
                previousSecondNode.next = currentFirstNode;
            }
            else
            {
                head = currentFirstNode;
            }

            Node temp = currentFirstNode.next;
            currentFirstNode.next = currentSecondNode.next;
            currentSecondNode.next = temp;

        }

        public Node SwitchNode2(Node firstNode, Node secondNode) //test
        {
           if (firstNode == null)
           {
                return null;
           }
           if (secondNode == null)
           {
                return null;
           }

           if (firstNode == secondNode)
           {
                return null;
           }

           int firstNodeData = firstNode.data;
           int secondNodeData = secondNode.data;
           Node head1 = this.head;
           Node head2 = this.head;

           while (head1.data != firstNodeData) 
           {
               head1 = head1.next;
           }

           while (head2.data != secondNodeData) 
           {
               head2 = head2.next;
           }

           int val = head1.data;
           head1.data = head2.data;
           head2.data = val;
           return head1;
        }
    }
}