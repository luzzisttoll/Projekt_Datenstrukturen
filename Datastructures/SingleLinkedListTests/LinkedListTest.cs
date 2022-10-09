using Datastructures;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject
{
    public class LinkedListTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSLLCount_AddItems_ReturnCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            myLL.insertLast(3);
            myLL.insertLast(4);
            Assert.AreEqual(4, myLL.count());
        }

        [Test]
        public void TestGetNode_MultipleItems_ReturnsNode()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(5);
            myLL.insertLast(1);
            myLL.insert_First(2);
            //var node = myLL.getNode(1);
            // Assert.AreEqual(1, node.data);


        }

        [Test]
        public void TestInsertLast_MultipleTimes_ItemsAdded()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(5);
            myLL.insertLast(1);
            myLL.insertLast(2);
            var node = myLL.GetHead();
            Assert.AreEqual(5, node.data);
            Assert.AreEqual(1, node.next.data);
            Assert.AreEqual(2, node.next.next.data);
        }

        [Test]
        public void TestInsertFirst_MultipleTimes_ItemsAdded()
        {
            var myLL = new SingleLinkedList();
            myLL.insert_First(5);
            myLL.insert_First(1);
            myLL.insert_First(2);
            var node = myLL.GetHead();
            Assert.AreEqual(2, node.data);
            Assert.AreEqual(1, node.next.data);
            Assert.AreEqual(5, node.next.next.data);
        }

        [Test]
        public void TestInsertAfter_MultipleTimes_ItemsAdded()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            myLL.insertLast(4);
            var node = myLL.GetHead();
            myLL.insert_After(3, 1);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(2, node.next.data);
            Assert.AreEqual(3, node.next.next.data);
        }

        [Test]
        public void TestDelete_MultipleTimes_ItemDeleted()
        {
            var myLL = new SingleLinkedList();
            myLL.insertLast(1);
            myLL.insertLast(2);
            myLL.insertLast(3);
            myLL.insertLast(4);
            var node = myLL.GetHead();
            myLL.DeleteNode(node.next);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(3, node.next.data);
            Assert.AreEqual(4, node.next.next.data);
        }
    }
}