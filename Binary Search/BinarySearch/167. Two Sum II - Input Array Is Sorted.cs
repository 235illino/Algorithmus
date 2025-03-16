using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
namespace BinarySearch
{
    class TwoSumClass
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> seen = new();
            var count = 1;
            foreach (var el in numbers)
            {
                var cand = target - el;
                if (seen.ContainsKey(cand))
                {
                    return [seen[cand], count];
                }
                else
                {
                    seen[el] = count;
                }
                count++;
            }
            return [];
        }
    }
}
