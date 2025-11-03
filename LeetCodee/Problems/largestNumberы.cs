using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public static class largestNumberы
    {
        public  static string largestNumber(int[] nums)
        {
            List<string> strNums = nums.Select(n => n.ToString()).ToList();
            strNums.Sort((a, b) => (b + a).CompareTo(a + b));
            if (strNums[0] == "0")
                return "0";
            return string.Join("", strNums);

        }
    }
}
