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

        public void SingleLinkedListTest()
        {
            Datastructures.SingleLinkedList linkedList = new Datastructures.SingleLinkedList();
            linkedList.insertLast(0);
            linkedList.insert_After(1, 0);
            Assert.AreEqual(linkedList.count(), 2);
            linkedList.DeleteNode(0);
            Assert.AreEqual(linkedList.count(), 1);
        }
    }
}