using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems.LinkedList
{
     public static class Example
     {
        public static int FindTarget(LinkedList<int> list)
        {
            var max = int.MinValue;
            foreach (int index in list)
            {
                if (max < index)
                    max = index;

            }
            return max;
        }
     }
}
