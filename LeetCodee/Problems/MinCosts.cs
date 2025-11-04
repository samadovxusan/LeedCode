using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public static class MinCosts
    {
        public static int MinCost(string colors, int[] neededTime)
        {
            int totalTime = 0;
            int n = colors.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (colors[i] == colors[i + 1])
                {
                    if (neededTime[i] < neededTime[i + 1])
                    {
                        totalTime += neededTime[i];
                    }
                    else
                    {
                        totalTime += neededTime[i + 1];
                        neededTime[i + 1] = neededTime[i];
                    }
                }
            }
            return totalTime;

        }
    }
}
