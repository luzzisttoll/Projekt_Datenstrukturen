using Datastructures;

namespace GenerischeKlassen
{
    class Program
    {
        public static void Main(String[] args)
        {
            Datastructures.SingleLinkedList linkedList = new Datastructures.SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(3);
            linkedList.insertLast(4);
            linkedList.insertLast(5);
            linkedList.insert_After(9, 2);
            linkedList.insert_First(7);
            linkedList.DeleteNode(3);

            linkedList.printList();
            Console.WriteLine(linkedList.GetNode(4));
        }
    }
}