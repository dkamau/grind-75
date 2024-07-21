using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode75.HeapQuestions
{
    internal static class MergeKSortedLists
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
                return null;

            var data = new List<int>();

            foreach (var node in lists)
            {
                var currentNode = node;
                while (currentNode != null)
                {
                    data.Add(currentNode.val);
                    currentNode = currentNode.next;
                }
            }

            if (data.Count == 0)
                return null;

            data.Sort();

            ListNode resultNode = new ListNode();
            ListNode temp = resultNode;


            foreach (var item in data)
            {
                temp.next = new ListNode(item);
                temp = temp.next;
            }


            return resultNode.next;
        }
    }


    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
