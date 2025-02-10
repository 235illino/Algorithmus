using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/design-linked-list/description/
namespace Linked_List
{
    public class MyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public class ListNode
        {
            public int val;
            public ListNode? next; 
            public ListNode(int val = 0, ListNode? next = null) 
            {
                this.val = val;
                this.next = next;
            }
        }

        public MyLinkedList()
        {
            head = new ListNode();
            tail = head;
        }

        public int Get(int index)
        {
            var curr = head;
            while (index >= 0)
            {
                if(curr.next is null)
                    return -1;
                curr = curr.next;
                index--;
            }

            return curr.val;
        }

        public void AddAtHead(int val)
        {
            var newHead = new ListNode(val, head.next);
            head.next = newHead;
            if(newHead.next is null)
                tail = newHead;
        }

        public void AddAtTail(int val)
        {
            var newTail = new ListNode(val);
            tail.next = newTail;
            tail = newTail;
        }

        public void AddAtIndex(int index, int val)
        {
            var curr = head;
            while (index > 0)
            {
                if (curr.next is null)
                    return;
                curr = curr.next;
                index--;
            }

            var newNode = new ListNode(val, curr.next);
            curr.next = newNode;
            if (newNode.next is null)
                tail = newNode;
        }

        public void DeleteAtIndex(int index)
        {
            var curr = head;
            while (index > 0)
            {
                if (curr.next is null)
                    return;
                curr = curr.next;
                index--;
            }
            curr.next = curr.next?.next;
            if (curr.next is null)
                tail = curr;
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
