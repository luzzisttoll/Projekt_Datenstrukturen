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
            myLL.insert(1);
            myLL.insert(1);
            myLL.insert(1);
            myLL.insert(1);
            Assert.AreEqual(4, myLL.count());
        }

        public void TestSSL_AddItemsToStart_ReturnCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insert(5);
            myLL.insert(1);
            myLL.insert_First(2);
            Assert.AreEqual(3, myLL.count());
        }
    }
}