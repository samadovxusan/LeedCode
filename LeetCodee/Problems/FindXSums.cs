using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodee.Problems
{
    public static class FindXSums
    {
        public static int[] FindXSum(int[] nums, int k, int x)
        {
            List<int> result = new();
            int n = nums.Length;

            for (int i = 0; i <= n - k; i++)
            {   
                // 1️⃣ Subarraydagi elementlar
                var freq = new Dictionary<int, int>();
                for (int j = i; j < i + k; j++)
                {
                    if (!freq.ContainsKey(nums[j]))
                        freq[nums[j]] = 0;
                    freq[nums[j]]++;
                }

                // 2️⃣ Eng ko‘p uchragan x ta elementni topamiz
                var topX = freq
                    .OrderByDescending(p => p.Value)  // Chastotaga ko‘ra
                    .ThenByDescending(p => p.Key)     // Agar chastota teng bo‘lsa — kattasini tanla
                    .Take(x)
                    .Select(p => p.Key)
                    .ToList();

                // 3️⃣ Shu elementlarni subarraydan yig‘ib chiqamiz
                int sum = 0;
                for (int j = i; j < i + k; j++)
                {
                    if (topX.Contains(nums[j]))
                        sum += nums[j];
                }

                result.Add(sum);
            }

            return result.ToArray();
        }
    }
}
