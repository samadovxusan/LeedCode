using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
   public static class MyAtois
    {
        public static int MyAtoi(string s)
        {
            s = s.Trim();
            s.Trim();
            if (s.Length == 0) return 0;
            int sign = 1, index = 0;
            long result = 0;
            if (s[index] == '+' || s[index] == '-')
            {
                sign = s[index] == '-' ? -1 : 1;
                index++;
            }
            while (index < s.Length && char.IsDigit(s[index]))
            {
                result = result * 10 + (s[index] - '0');
                if (sign * result > int.MaxValue) return int.MaxValue;
                if (sign * result < int.MinValue) return int.MinValue;
                index++;
            }
            return (int)(sign * result);
        }
    }
}
