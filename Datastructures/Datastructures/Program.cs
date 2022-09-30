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

            mySLL.insert(5);
            mySLL.count();
            mySLL.printList();
        }
    }
}