using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class DuplicateZerosClass
    {
        public void DuplicateZeros(int[] arr)
        {
            var countZero = 0;
            var last = arr.Length - 1;
            for (int i = 0; i < arr.Length - countZero; i++)
            {
                if (arr[i] == 0)
                {
                    if (last - countZero == i)
                    {
                        arr[arr.Length - 1] = 0;
                        last--;
                        break;
                    }
                    countZero++;
                }
            }
            last -= countZero;
            for (int i = last; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    arr[i + countZero] = 0;
                    countZero--;
                    arr[i + countZero] = 0;
                }
                else
                {
                    arr[i + countZero] = arr[i];
                }
            }
        }


        // public void DuplicateZeros(int[] arr) {
        //     for(int i = 0; i < arr.Length - 1; i++){
        //         if(arr[i] == 0){
        //             int k = arr.Length - 1;
        //             while(k > i){
        //                 arr[k] = arr[k - 1];
        //                 k--;
        //             }
        //             arr[k] = 0;
        //             i++;
        //         }
        //     }
        // }


    }
}
