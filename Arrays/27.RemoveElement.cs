using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class RemoveElementClass
    {
        public int RemoveElement(int[] nums, int val)
        {
            int read = 0, position = nums.Length;
            while (read < position)
            {
                if (nums[read] == val)
                {
                    position--;
                    (nums[read], nums[position]) = (nums[position], nums[read]);
                }
                if (nums[read] != val)
                    read++;
            }
            return position;
        }
    }
}
