using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/find-smallest-letter-greater-than-target/
namespace BinarySearch
{
    internal class NextGreatestLetterClass
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int bad = -1, good = letters.Length;
            while (good - bad > 1)
            {
                var mid = bad + (good - bad) / 2;
                if (letters[mid] > target)
                {
                    good = mid;
                }
                else
                {
                    bad = mid;
                }
            }

            return good == letters.Length ? letters[0] : letters[good];
        }
    }
}
