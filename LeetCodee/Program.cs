namespace LeetCodee;

class Program
{
    static void Main(string[] args)
    {
        var str = "()[]{}{{{{}";

        Console.WriteLine(FizzBuzz.IsValidParentheses(str));
    }
}