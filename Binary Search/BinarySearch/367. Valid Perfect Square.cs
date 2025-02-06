using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/valid-perfect-square/description/
namespace BinarySearch
{
    internal class PerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            // double bad = 0, good = num;
            // while(good - bad > 0.00001){
            //     double mid = bad + (good - bad) / 2.0;
            //     if(mid >= num / mid){
            //         good = mid;
            //     } else{
            //         bad = mid;
            //     }
            // }
            // return good % 1 < 0.00001;
            double bad = 0, good = num;
            double mid = bad + (good - bad) / 2.0;
            while (good != mid && bad != mid)
            {
                if (mid >= num / mid)
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }
                mid = bad + (good - bad) / 2.0;
            }
            return good % 1 == 0;
        }
    }
}
