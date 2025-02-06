using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-peak-element/description/
namespace BinarySearch.Template_II
{
    public class FindPeakElementClass
    {
        public int FindPeakElement(int[] nums)
        {
            //         int good = 0, bad = nums.Length - 1;
            //         while(good < bad){
            //             var mid = good + (bad - good) / 2;
            //             if(mid != nums.Length - 1 && nums[mid] < nums[mid + 1]){
            //                 good = mid + 1;
            //             } else{
            //                 bad = mid;
            //             }
            //         }
            //         if(good == 0 || good == nums.Length - 1 && nums[good] > nums[good - 1] 
            //            || nums[good] > nums[good - 1] && nums[good] > nums[good + 1])
            //             return good;

            //         return good - 1;



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
