using Datastructures;

namespace GenerischeKlassen
{
    class Program
    {
        public static void Main(String[] args)
        {
            SingleLinkedList mySLL = new SingleLinkedList();

            mySLL.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            mySLL.head.next = second;
            second.next = third;

            mySLL.insert(4);
            //mySLL.count();
            //mySLL.insert_First(2);
            //mySLL.insert_After(9, 3);
            mySLL.printList();
            //mySLL.getNode(2);
            mySLL.DeleteNode(new Node(1));
            mySLL.printList();
        }
    }
}