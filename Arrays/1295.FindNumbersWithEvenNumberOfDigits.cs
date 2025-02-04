using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
namespace Arrays
{
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var count = 0;
                while (nums[i] > 0)
                {
                    nums[i] = nums[i] / 10;
                    count++;
                }
                if (count % 2 == 0)
                    result++;
            }
            return result;
        }
    }
}
