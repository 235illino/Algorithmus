using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/intersection-of-two-arrays-ii/
namespace BinarySearch
{
    class IntersectClassII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                Intersect(nums2, nums1);
            Dictionary<int, int> dic = new();
            List<int> res = new();
            foreach (var num in nums1)
            {
                if (!dic.TryAdd(num, 1))
                {
                    dic[num]++;
                }
            }
            foreach (var num in nums2)
            {
                if (dic.ContainsKey(num))
                {
                    res.Add(num);
                    dic[num]--;
                    if (dic[num] == 0)
                        dic.Remove(num);
                }

                if (dic.Count == 0)
                    break;
            }
            return res.ToArray();


            //         if(nums1.Length > nums2.Length)
            //             return Intersect(nums2, nums1);
            //         List<int> arr = new();
            //         Dictionary<int, int> seen = new();
            //         foreach(var el in nums2){
            //             if(!seen.TryAdd(el, 1)){
            //                 seen[el]++;
            //             }
            //         }
            //         foreach(var el in nums1){
            //             if(seen.ContainsKey(el) && seen[el] > 0){
            //                 seen[el]--;
            //                 arr.Add(el);
            //             }
            //         }
            //         return arr.ToArray();
        }
    }
}
