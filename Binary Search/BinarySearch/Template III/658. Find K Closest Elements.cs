using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
//https://leetcode.com/problems/find-k-closest-elements/description/
namespace BinarySearch.Template_III
{
    public class FindClosestElementsClass
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var l = -1;
            var r = arr.Length - k + 1;
            while (r - l > 1)
            {
                var m = l + (r - l) / 2;
                if (m + k >= arr.Length || x - arr[m] <= arr[m + k] - x)
                    r = m;
                else
                    l = m;
            }
            return arr[r..(r + k)];
        }


        // public IList<int> FindClosestElements(int[] arr, int k, int x) {
        //     var sumMin = arr.Take(k).Select(a => (Math.Abs(a - x))).Sum();
        //     var curr = sumMin;
        //     var ind = 0;
        //     for(int i = k; i < arr.Length; i++){
        //         var priv = Math.Abs(arr[i - k] - x);
        //         var next = Math.Abs(arr[i] - x);
        //         curr = curr - priv + next;
        //         if(curr < sumMin){
        //             sumMin = curr;
        //             ind = i - k + 1;
        //         }
        //     }
        //     return arr[ind..(ind + k)];
        // }
    }

}
