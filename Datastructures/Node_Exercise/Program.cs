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
            //linkedList.InsertAfter(9, 2);
            //linkedList.insert_First(7);
            //linkedList.DeleteNode(3);
            //linkedList.GetNode(4);
            linkedList.SwitchNode2(new Node(2, null), new Node(4, null));
            
            //linkedList.Switchnodes2(new Node(1), new Node(3));
            linkedList.printList();
            //Console.WriteLine(linkedList.GetNode(4));
        }
    }
}