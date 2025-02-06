using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
namespace BinarySearch.Template_III
{
    public class SearchRangeClass
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var l = BiSearch(nums, target, false);
            var r = l == -1 ? -1 : BiSearch(nums, target + 1, true);
            return [l, r];
        }

        private int BiSearch(int[] nums, int target, bool isRight)
        {
            int bad = -1, good = nums.Length;
            if (good == 0)
            {
                return -1;
            }

            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                if (nums[mid] >= target)
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }
            }
            if (isRight)
            {
                return good - 1;
            }
            if (good != nums.Length && nums[good] == target)
            {
                return good;
            }
            else
            {
                return -1;
            }
        }
    }
}
