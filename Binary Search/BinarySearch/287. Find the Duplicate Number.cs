using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-the-duplicate-number/
namespace BinarySearch
{
    internal class FindDuplicateClass
    {
        public int FindDuplicate(int[] nums)
        {

            //         int tor = nums[0], rab = nums[0];
            //         do {
            //             tor = nums[tor];
            //             rab = nums[nums[rab]];

            //         } while(tor != rab);
            //         tor = nums[0];
            //         while(tor != rab){
            //             tor = nums[tor];
            //             rab = nums[rab];
            //         }
            //         return tor;
            int bad = 0, good = nums.Length - 1;
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                var count = nums.Count(el => el <= mid);
                if (count > mid)
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
    }
}
