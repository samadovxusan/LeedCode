using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public static class GenerateParenthesis
    {
        public static IList<string> GenerateParenthesisMethod(int n)
        {
            List<string> result = new List<string>();
            GenerateParenthesisHelper(result, "", 0, 0, n);
            return result;
        }
        private static void GenerateParenthesisHelper(List<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }
            if (open < max)
            {
                GenerateParenthesisHelper(result, current + "(", open + 1, close, max);
            }
            if (close < open)
            {
                GenerateParenthesisHelper(result, current + ")", open, close + 1, max);
            }
        }
    }
}
