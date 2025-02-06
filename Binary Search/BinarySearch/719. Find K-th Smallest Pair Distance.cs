using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-k-th-smallest-pair-distance/
namespace BinarySearch
{
    internal class SmallestDistancePairClass
    {
        public int SmallestDistancePair(int[] nums, int k)
        {
            Array.Sort(nums);
            int bad = -1, good = nums[^1] - nums[0] + 1;
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                var cand = CalcPair(mid, nums);
                if (cand >= k)
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

        public int CalcPair(int dist, int[] nums)
        {
            int l = 0, calcPairs = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                while (nums[r] - nums[l] > dist)
                {
                    l++;
                }
                calcPairs += r - l;
            }
            return calcPairs;
        }
    }
}
