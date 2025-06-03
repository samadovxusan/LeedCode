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

}