using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class CheckIfExistClass
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(arr);
            var count = 0;
            foreach (var num in arr)
            {
                if (num == 0)
                    count++;
                if (count > 1)
                    return true;
                else if (num != 0 && set.Contains(num * 2))
                    return true;
            }
            return false;
        }
    }
}
