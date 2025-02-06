using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/split-array-largest-sum/
namespace BinarySearch
{
    internal class SplitArrayClass
    {
        public int SplitArray(int[] nums, int k)
        {
            int bad = nums.Max() - 1, good = nums.Sum();
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                if (CalcSubArray(nums, mid) <= k)
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }
            }
            return good;
        }

        public int CalcSubArray(int[] nums, int cand)
        {
            int sum = 0, subCalc = 0;
            foreach (var el in nums)
            {
                if (sum + el <= cand)
                {
                    sum += el;
                }
                else
                {
                    sum = el;
                    subCalc++;
                }
            }
            return subCalc + 1;
        }
    }
}
