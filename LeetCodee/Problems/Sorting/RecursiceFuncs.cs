using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems.Sorting
{
   public static class RecursiceFuncs
    {
        public static int Sum_recursive(IList<int> nums,int index = 0)
        {
            if ( index >=nums.Count)
                return 0;
            return nums[index] + Sum_recursive(nums ,index +1);
        }


        public static int Fib(int n)
        {
            if (n <= 1)
                return n;

            return Fib(n - 1) + Fib(n - 2);
        }
        public static long FibIter(int n)
        {
            if (n <= 1)
                return n;

            long a = 0;
            long b = 1;

            for (int i = 2; i <= n; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

    }
}
