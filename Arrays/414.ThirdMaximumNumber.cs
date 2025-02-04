using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/third-maximum-number/description/
namespace Arrays
{
    public class ThirdMaxClass
    {
        public int ThirdMax(int[] nums)
        {
            var set = new HashSet<int>(nums);
            int res = int.MinValue;
            PriorityQueue<int, int> que = new();

            foreach (var el in set)
            {
                if (que.Count < 3)
                {
                    que.Enqueue(el, el);
                    if (el > res)
                        res = el;
                }
                else if (que.Peek() < el)
                {
                    que.EnqueueDequeue(el, el);
                }
            }

            return que.Count != 3 ? res : que.Peek();
        }
    }
}
