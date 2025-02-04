using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ValidMountainArrayClass
    {
        public bool ValidMountainArray(int[] arr)
        {
            int l = 0;
            while (l < arr.Length - 1 && arr[l] < arr[l + 1])
                l++;
            if (l == 0 || l == arr.Length - 1)
                return false;
            while (l < arr.Length - 1 && arr[l] > arr[l + 1])
                l++;
            if (l != arr.Length - 1)
                return false;
            return true;
        }
    }
}
