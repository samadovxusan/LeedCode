using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
   public static class ThreeSumClosests
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums); // 1. Massivni tartiblaymiz
            int n = nums.Length;
            int closestSum = nums[0] + nums[1] + nums[2]; // boshlang‘ich qiymat

            for (int i = 0; i < n - 2; i++)
            {
                int left = i + 1;
                int right = n - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    // 2. Eng yaqin natijani yangilaymiz
                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = sum;
                    }

                    // 3. Harakat yo‘nalishini aniqlaymiz
                    if (sum < target)
                        left++;
                    else if (sum > target)
                        right--;
                    else
                        return sum; // to‘g‘ri target topildi
                }
            }

            return closestSum;
        }

    }
}
