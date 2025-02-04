using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RemoveDuplicatesClass
    {
        public int RemoveDuplicates(int[] nums)
        {
            int l = 0;
            int r = 0;
            while (r < nums.Length - 1)
            {
                r++;
                if (nums[l] != nums[r])
                {
                    l++;
                    nums[l] = nums[r];
                }
            }
            return l + 1;
        }
    }
}
