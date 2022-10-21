using Datastructures;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestProject
{
    public class LinkedListTest
    {
        public Node head;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSLLCount_AddItems_ReturnCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            myLL.insertLast(1);
            Assert.AreEqual(4, myLL.count());
        }

        [Test]
        public void SingleLinkedListTest_DeleteItem_ReturnCorrectCount()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(0);
            //linkedList.InsertAfter(3, 0);
            Assert.AreEqual(linkedList.count(), 2);
            linkedList.DeleteNode(0);
            Assert.AreEqual(linkedList.count(), 1);
        }

        [Test]
        public void SSLTest_GetNode_ReturnsElement()
        {
            var linkedList = new SingleLinkedList();
            var getnode = linkedList.GetNode(1);
            linkedList.insertLast(2);
            linkedList.insertLast(1);
            linkedList.insertLast(3);
            Assert.AreEqual(head.next, getnode);
        }

        [Test]
        public void SSLTest_SwitchNodes_ReturnCorrectOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(1);
            linkedList.insertLast(5);
            var node1 = linkedList.GetNode(1).data;
            var node2 = linkedList.GetNode(5).data;
            linkedList.SwitchNode(node1, node2);
            Assert.AreEqual(5, node1);

        }

        [Test]
        public void SSLTestSwitchNodes_SwitchMiddleNodes_ReturnCorrectOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(3);
            linkedList.insertLast(4);
            linkedList.insertLast(5);

            var node1 = linkedList.GetNode(2).data;
            var node2 = linkedList.GetNode(4).data;
            linkedList.SwitchNode(node1, node2);

            Assert.AreEqual(linkedList.ToString(), "| 1 | 4 | 3 | 2 | 5 |");
        }

        [Test]
        public void SSLTestSwitchNodes_SwitchFirstNodeWithLast_ReturnCorrectOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(3);
            linkedList.insertLast(4);
            linkedList.insertLast(5);

            var node1 = linkedList.GetNode(1).data;
            var node2 = linkedList.GetNode(5).data;
            linkedList.SwitchNode(node1, node2);
            
            Assert.AreEqual(linkedList.ToString(), "| 5 | 2 | 3 | 4 | 1 |");
        }


    }
}