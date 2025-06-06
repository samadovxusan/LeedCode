using System.Collections.Specialized;

namespace LeetCodee;

public static class FizzBuzz
{
    public static void FizzaBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"FizzBuzz {i}");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine($"Fizz {i}");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"Buzz {i}");
            }
            else
            {
                Console.WriteLine($"Sonni ozi {i}");
            }
        }
    }

    public static bool IsPalindrome(int number)
    {
        string original = number.ToString();
        char[] arr = original.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        return original == reversed;
    }

    public static string CloseNumber(List<int> numbers)
    {
        numbers.Sort();

        int minDiff = int.MaxValue;
        string closestPair = "";

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            int diff = Math.Abs(numbers[i] - numbers[i + 1]);

            if (diff < minDiff)
            {
                minDiff = diff;
                closestPair = $"{numbers[i]} , {numbers[i + 1]}";
            }
        }

        return closestPair;
    }

    public static bool IsValidParentheses(string s)
    {
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                char top = stack.Pop();

                if (c == ')' && top != '(') return false;
                if (c == '}' && top != '{') return false;
                if (c == ']' && top != '[') return false;
            }
        }

        return stack.Count == 0;
    }

    public static int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length == 3)
        {
            return nums[0] + nums[1] + nums[2];
        }

        Array.Sort(nums);

        var smallestSum = nums[0] + nums[1] + nums[2];

        if (target < 0 && smallestSum >= target)
        {
            return smallestSum;
        }

        var greatestSum = nums[^1] + nums[^2] + nums[^3];

        if (target >= 0 && greatestSum <= target)
        {
            return greatestSum;
        }

        int closestSum = int.MaxValue;
        int result = 0;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == target)
                {
                    return sum;
                }

                if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = sum;
                    result = sum;
                }

                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}