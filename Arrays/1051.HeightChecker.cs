using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class HeightCheckerClass
    {
        public int HeightChecker(int[] heights)
        {
            var count = 0;
            var arr = new int[101];
            var ind = 0;
            foreach (var el in heights)
            {
                arr[el]++;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    if (heights[ind] != i)
                    {
                        heights[ind] = i;
                        count++;
                    }
                    arr[i]--;
                    ind++;
                }
            }
            return count;
        }
        // public int HeightChecker(int[] heights) {
        //     var orig = new int[heights.Length];
        //     Array.Copy(heights, orig, heights.Length);
        //     bool hasSwap = true;
        //     var count = 0;
        //     while(hasSwap){
        //         hasSwap = false;
        //         for(int i = 0; i < heights.Length - 1; i++){
        //             if(heights[i] > heights[i + 1]){
        //                 (heights[i], heights[i + 1]) = (heights[i + 1], heights[i]);
        //                 hasSwap = true;
        //             }
        //         }
        //     }
        //     for(int i = 0; i < orig.Length; i++){
        //         if(orig[i] != heights[i]){
        //             count++;
        //         }
        //     }
        //     return count;
        // }
    }
}
