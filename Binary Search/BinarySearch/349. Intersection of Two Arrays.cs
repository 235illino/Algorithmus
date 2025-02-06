using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/intersection-of-two-arrays/
namespace BinarySearch
{
    internal class IntersectionClass
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            //         if(nums1.Length > nums2.Length)
            //             Intersection(nums2, nums1);
            //         List<int> res = new();
            //         var set1 = new HashSet<int>(nums1);
            //         Array.Sort(nums2);
            //         foreach(var el in set1){
            //             if(BiSearch(nums2, el)){
            //                 res.Add(el);
            //             }
            //         }
            //         return res.ToArray();

            //     }
            //     private bool BiSearch(int[] nums, int target){
            //         int bad = -1, good = nums.Length;
            //         while(good - bad > 1){
            //             var mid = bad + (good - bad) / 2;
            //             if(nums[mid] >= target){
            //                 good = mid;
            //             }
            //             else{
            //                 bad = mid;
            //             }
            //         }

            //         return good == nums.Length ? false : nums[good] == target;




            HashSet<int> nums = new(nums1);
            nums.IntersectWith(nums2);
            return nums.ToArray();
        }
    }
}
