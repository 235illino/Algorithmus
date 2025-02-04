using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/squares-of-a-sorted-array/description/
namespace Arrays
{
    public class SortedSquaresClass
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int l = 0, r = nums.Length - 1, index = nums.Length - 1;
            while (l <= r)
            {
                var leftElm = nums[l] * nums[l];
                var rightElm = nums[r] * nums[r];
                if (leftElm > rightElm)
                {
                    result[index] = leftElm;
                    l++;
                }
                else
                {
                    result[index] = rightElm;
                    r--;
                }
                index--;
            }
            return result;
        }
    }
}
