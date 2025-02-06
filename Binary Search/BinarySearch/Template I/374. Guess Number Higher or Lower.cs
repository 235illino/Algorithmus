using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Template_I
{
    public abstract class GuessGame
    {
        public abstract int Guess(int num, int n);
        
    }
    public class Solution : GuessGame
    {
        public override int Guess(int num, int n)
        {
            if(num > n)
            {
                return -1;
            }
            else if (num < n)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int GuessNumber(int n)
        {
            int left = 1, right = n;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var num = Guess(mid, n);
                if (num == 0)
                {
                    return mid;
                }
                else if (num == -1)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
