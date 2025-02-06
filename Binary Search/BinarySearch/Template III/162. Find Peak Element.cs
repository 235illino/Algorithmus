using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-peak-element/description/
namespace BinarySearch.Template_III
{
    internal class FindPeakElementClass
    {
        public int FindPeakElement(int[] nums)
        {

            int bad = -1, good = nums.Length;
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                if (mid != nums.Length - 1 && nums[mid] >= nums[mid + 1])
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }

            }
            if (good == nums.Length)
            {
                return good - 1;
            }
            return good;


        }
    }
}
