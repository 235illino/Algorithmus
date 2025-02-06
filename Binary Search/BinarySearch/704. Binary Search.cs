using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/binary-search/
namespace BinarySearch
{
    public class SearchClass
    {
        public int Search(int[] nums, int target)
        {
            int bad = -1, good = nums.Length;
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
            if (good < nums.Length && nums[good] == target)
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
