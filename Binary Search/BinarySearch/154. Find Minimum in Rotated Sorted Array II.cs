using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
namespace BinarySearch
{
    internal class FindMinClass
    {
        public int FindMin(int[] nums)
        {
            int bad = -1, good = nums.Length - 1;
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                if (nums[mid] < nums[good])
                {
                    good = mid;
                }
                else if (nums[mid] > nums[good])
                {
                    bad = mid;
                }
                else
                {
                    good--;
                }
            }
            return nums[good];

        }
    }
}
