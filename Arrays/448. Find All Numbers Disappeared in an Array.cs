using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
namespace Arrays
{
    public class FindDisappearedNumbersClass
    {
        public IList<int> FindDisappearedNumbers(int[] array)
        {
            var res = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int index = array[i] - 1;
                while (index != -1)
                {
                    int temp = array[index];
                    array[index] = 0;
                    index = temp - 1;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    res.Add(i + 1);
                }
            }
            return res;
        }
    }
}
