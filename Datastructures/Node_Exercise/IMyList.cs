using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IMyList
    {
        void SwitchNode(int firstNode, int secondNode);
        void SetSortStrategy(SortStrategy sortStrategy);
        Node GetFirst();
        void Sort();
    }

    public abstract class SortStrategy
    {
        public abstract void Sort(IMyList list);
    }

    public class InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data < nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }

    public class InsertionSortInverse : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var nextNode = list.GetFirst().next;

            while (nextNode != null)
            {
                for (var cur = list.GetFirst(); cur.next != null; cur = cur.next)
                {
                    if (cur == nextNode)
                        break;
                    if (cur.data > nextNode.data)
                        continue;
                    (cur.data, nextNode.data) = (nextNode.data, cur.data);
                }
                nextNode = nextNode.next;
            }
            Console.WriteLine("InsertionSorted list ");
        }
    }

    public class BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            bool sort = true;
            while (sort)
            {
                sort = false;
                Node currentNode = list.GetFirst();
                Node currentNodeNext = list.GetFirst().next;
                while (currentNodeNext != null)
                {
                    if (currentNode.data > currentNodeNext.data)
                    {
                        (currentNode.data, currentNodeNext.data) = (currentNodeNext.data, currentNode.data);
                        sort = true;
                    }
                    currentNode = currentNode.next;
                    currentNodeNext = currentNodeNext.next;
                }
            }
        }
    }
}