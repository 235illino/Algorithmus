using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/search-in-rotated-sorted-array/description/
namespace BinarySearch.Template_I
{
    public class SearchClass
    {
        public int Search(int[] nums, int target)
        {
            var pivot = SearchPivot(nums);
            if (target > nums[^1])
            {
                return SearchBin(nums, target, 0, pivot);
            }
            else
            {
                return SearchBin(nums, target, pivot, nums.Length);
            }
        }

        public int SearchBin(int[] nums, int target, int l, int r)
        {
            // while(l <= r){
            //     var mid = (r + l) / 2;
            //     if(nums[mid] == target){
            //         return mid;
            //     } else if(nums[mid] > target){
            //         r = mid - 1;
            //     } else {
            //         l = mid + 1;
            //     }
            // }
            // return -1;
            int bad = l - 1, good = r;
            while (good - bad > 1)
            {
                var mid = (good + bad) / 2;
                if (nums[mid] >= target)
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }
            }
            if (good != r && nums[good] == target)
                return good;
            return -1;
        }


        public int SearchPivot(int[] nums)
        {
            // int l = 0, r = nums.Length - 1;
            // while(l <= r){
            //     int mid = (r + l) / 2;
            //     if(mid != 0 && nums[mid - 1] >= nums[mid] || mid == 0 && nums[^1] >= nums[mid]){
            //         return mid;
            //     } else if(nums[mid] >= nums[0] && nums[mid] >= nums[^1]){
            //         l = mid + 1;
            //     } else{
            //         r = mid - 1;
            //     }
            // }
            // return -1;
            int l = -1, r = nums.Length;
            while (r - l > 1)
            {
                var mid = (r + l) / 2;
                if (nums[mid] <= nums[0] && nums[mid] <= nums[^1])
                {
                    r = mid;
                }
                else
                {
                    l = mid;
                }
            }
            if (r == nums.Length)
                return 0;
            return r;
        }
    }
    // m  1
    // l  -1
    // r  3



    //      3 1
    //      0 1

    //     [4,5,6,7,0,1,2]
    //      0 0 0 0 1 1 1

}
