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
            linkedList.insert_After(1, 0);
            Assert.AreEqual(linkedList.count(), 2);
            linkedList.DeleteNode(0);
            Assert.AreEqual(linkedList.count(), 1);
        }

        [Test]
        public void SSLTest_GetNode_ReturnsElement()
        {
            var linkedList = new SingleLinkedList();
            linkedList.GetNode(0);
            linkedList.insertLast(1);
            linkedList.insertLast(2);
            linkedList.insertLast(3);
        }
    }
}