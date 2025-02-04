using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
namespace Arrays
{
    class ReplaceElementsClass
    {
        public int[] ReplaceElements(int[] arr)
        {
            int i = arr.Length - 1;
            int max = arr[i];
            arr[i] = -1;
            while (i > 0)
            {
                var temp = arr[i - 1];
                arr[i - 1] = max;
                max = Math.Max(temp, max);
                i--;
            }
            return arr;

        }
    }
}
