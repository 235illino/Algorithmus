using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/design-linked-list/description/
namespace Linked_List
{
    public class DoublyMyLinkedList
    {
        private ListNode head;
        private ListNode tail;
        int size;

        public class ListNode
        {
            public int val;
            public ListNode? next;
            public ListNode? priv;
            public ListNode(int val = 0, ListNode? next = null, ListNode? priv = null)
            {
                this.val = val;
                this.next = next;
                this.priv = priv;
            }
        }

        public DoublyMyLinkedList()
        {
            head = new ListNode();
            tail = new ListNode();
            head.next = tail;
            tail.priv = head;
            size = 0;
        }

        public int Get(int index)
        {
            if(index < 0 || index >= size)
                return -1;
            ListNode? curr = null;
            if (index < size / 2)
                curr = GetNodeAtIndexFromHead(index, head);
            else
                curr = GetNodeAtIndexFromTail(index, tail);            
            return curr.val;
        }

        private ListNode GetNodeAtIndexFromTail(int index, ListNode? tail)
        {
            var curr = tail;
            for (int i = 0; i < size - index; i++)
                curr = curr?.priv;
            return curr;
        }

        private static ListNode GetNodeAtIndexFromHead(int index, ListNode? head)
        {
            var curr = head;
            for (int i = 0; i <= index; i++)
                curr = curr?.next;
            return curr;
        }

        public void AddAtHead(int val)
        {
            size++;
            var toAdd = new ListNode(val, head.next, head);
            head.next.priv = toAdd;
            head.next = toAdd;
        }

        public void AddAtTail(int val)
        {
            size++;
            var toAdd = new ListNode(val, tail, tail.priv);
            tail.priv.next = toAdd;
            tail.priv = toAdd;
        }

        public void AddAtIndex(int index, int val)
        {
            if (index < 0 || index >= size)
                return;
            
            ListNode? curr = null;
            if (index < size / 2)
                curr = GetNodeAtIndexFromHead(index, head);
            else
                curr = GetNodeAtIndexFromTail(index, tail);
            size++;
            ListNode toAdd = new ListNode(val, curr, curr.priv);
            curr.priv.next = toAdd;
            curr.priv = toAdd;
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= size)
                return;
            ListNode? curr = null;
            if (index < size / 2)
                curr = GetNodeAtIndexFromHead(index, head);
            else
                curr = GetNodeAtIndexFromTail(index, tail);
            size--;
            curr.priv.next = curr.next;
            curr.next.priv = curr.priv;
        }
    }
    public class SinglyMyLinkedList
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

        public SinglyMyLinkedList()
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
