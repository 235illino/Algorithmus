using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/merge-sorted-array/description/
namespace Arrays
{
    public class MergeClass
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int insert = nums1.Length - 1;
            n--;
            m--;
            while (insert >= 0 && n >= 0)
            {
                if (m < 0 || nums1[m] <= nums2[n])
                {
                    nums1[insert] = nums2[n];
                    n--;
                }
                else
                {
                    nums1[insert] = nums1[m];
                    m--;
                }
                insert--;
            }
        }
    }
}
