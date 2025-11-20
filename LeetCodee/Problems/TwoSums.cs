using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    result.Append(nums[i] + nums[i + 1]);
                }
            }
            return result;

        }
    }
}
