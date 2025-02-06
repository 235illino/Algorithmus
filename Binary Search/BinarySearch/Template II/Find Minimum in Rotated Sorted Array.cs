using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
namespace BinarySearch.Template_II
{
    public class FindMinClass
    {
        public int FindMin(int[] nums)
        {
            int bad = -1, good = nums.Length;
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                if (nums[mid] <= nums[^1])
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }
            }
            if (good != nums.Length)
                return nums[good];
            else
                return nums[^1];
        }
    }
}
