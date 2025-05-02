using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee
{
    public static class RemoveElementArray
    {
            public static int RemoveElement(int[] nums, int val)
            {
                int result = 0;
                foreach (var item in nums)
                {
                    if (item != val)
                    {
                        nums[result] = item;
                        result++;
                    }
                }

                return result;
            }
    }
    public static class RemoveElementArray2
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int result = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
        public static int RemoveElementTwo(int[] nums, int val)
        {
            int result = 0;
            foreach (var item in nums)
            {
                if (item != val)
                {
                    nums[result] = item;
                    result++;
                }
            }

            return result;
        }
    }
}
