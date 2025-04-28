using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/design-circular-queue/
namespace Design
{
    public class MyCircularQueue
    {
        private int head;
        private int tail;
        private int len;
        private int[] arr;

        public MyCircularQueue(int k)
        {
            arr = new int[k];
            head = -1;
            tail = -1;
            len = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }
            if (IsEmpty())
            {
                head = 0;
                tail = 0;
            }
            else
            {
                tail = ++tail % len;
            }
            arr[tail] = value;
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }
            if (head == tail)
            {
                head = -1;
                tail = -1;
            }
            else
            {
                head = ++head % len;
            }
            return true;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return arr[head];
        }

        public int Rear()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return arr[tail];
        }

        public bool IsEmpty()
        {
            return head == -1 && tail == -1;
        }

        public bool IsFull()
        {
            return (head - tail == 1) || (head == 0 && tail == len - 1);
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}
