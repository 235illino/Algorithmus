using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/sqrtx/description/
namespace BinarySearch.Template_I
{
    public class MySqrtClass
    {
        public int MySqrt(int x)
        {
            if (x == 0)
                return 0;
            if (x == 1)
                return 1;
            int bad = 0, good = x;
            while (good >= bad)
            {
                var mid = bad + (good - bad) / 2;
                if (mid == x / mid)
                {
                    return mid;
                }
                else if (mid > x / mid)
                {
                    good = mid - 1;
                }
                else
                {
                    bad = mid + 1;
                }
            }
            return good;
        }
    }
}
