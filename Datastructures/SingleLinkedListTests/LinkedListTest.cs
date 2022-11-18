using Common;
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
        public void SSLTest_NodeExists_ReturnsNode()
        {
            var linkedList = new SingleLinkedList();
            var getnode = linkedList.GetNode(1);
            Assert.AreEqual(getnode, null);
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(3);
            getnode = linkedList.GetNode(1);
            Assert.AreNotEqual(getnode, null);
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
        public void TestStrategyPatternBubbleSort_InsertNumbers1665_ReturnRightOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new BubbleSort());
            linkedList.insertLast(1);
            linkedList.insertLast(8);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 1);
            Assert.AreEqual(linkedList.head.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.next.data, 8);
        }


        [Test]
        public void TestInsertionSortInverse_InsertSameNumbers1665_ReturnReverseOrder()
        {
            var linkedList = new SingleLinkedList();
            linkedList.SetSortStrategy(new InsertionSortInverse());
            linkedList.insertLast(1);
            linkedList.insertLast(6);
            linkedList.insertLast(5);
            linkedList.insertLast(6);
            linkedList.Sort();
            Assert.AreEqual(linkedList.head.data, 6);
            Assert.AreEqual(linkedList.head.next.data, 6);
            Assert.AreEqual(linkedList.head.next.next.data, 5);
            Assert.AreEqual(linkedList.head.next.next.next.data, 1);
        }
    }
}