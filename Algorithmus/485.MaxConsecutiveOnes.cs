using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/max-consecutive-ones/
namespace Arrays
{
    internal class MaxConsecutiveOnesClass
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int cur = 0;
            int res = 0;
            foreach (var el in nums)
            {
                if (el == 1)
                    cur++;
                else
                    cur = 0;
                res = Math.Max(cur, res);
            }
            return res;
        }
    }
}
