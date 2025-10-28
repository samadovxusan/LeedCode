using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public static class TwoSumNums
    {
        public static int[] Sum(int[] nums, int target)
        {
            List<int> result = new();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.AddRange(i);
                        result.AddRange(j);
                    }
                }
            }

            return result.ToArray();
        }
    }
}