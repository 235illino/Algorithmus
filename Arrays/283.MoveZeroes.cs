using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/move-zeroes/description/
namespace Arrays
{
    public class MoveZeroesClass
    {
        public void MoveZeroes(int[] nums)
        {
            int i = 0;
            while (i < nums.Length && nums[i] != 0)
                i++;
            int l = i, r = i + 1;
            while (r < nums.Length)
            {
                if (nums[r] != 0)
                {
                    nums[l] = nums[r];
                    nums[r] = 0;
                    l++;
                }
                r++;
            }
        }
    }
}
