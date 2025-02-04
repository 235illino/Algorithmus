using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class SortArrayByParityClass
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int start = 0, end = nums.Length - 1;
            while (start < end)
            {
                if (nums[start] % 2 != 0)
                {
                    while (start < end && nums[end] % 2 != 0)
                    {
                        end--;
                    }
                    (nums[start], nums[end]) = (nums[end], nums[start]);
                }
                start++;
            }
            return nums;
        }
    }
}
