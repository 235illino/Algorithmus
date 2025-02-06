using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/first-bad-version/description/
namespace BinarySearch.Template_II
{
    public class FirstBadVersionClass : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            int good = 0, bad = n;
            while (good < bad)
            {
                var cand = good + (bad - good) / 2;
                if (!IsBadVersion(cand))
                {
                    good = cand + 1;
                }
                else
                {
                    bad = cand;
                }
            }
            if (IsBadVersion(good))
                return good;
            else
                return good + 1;

        }

        public override bool IsBadVersion(int version)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class VersionControl
    {
        public abstract bool IsBadVersion(int version);
        
    }
}
