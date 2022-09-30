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
        public void TestSLLCound_AddItems_ReturnCorrectCount()
        {
            var myLL = new SingleLinkedList();
            myLL.insert(1);
            myLL.insert(1);
            myLL.insert(1);
            myLL.insert(1);
            Assert.AreEqual(4, myLL.count());
        }
    }
}