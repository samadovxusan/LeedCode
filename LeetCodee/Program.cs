namespace LeetCodee;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Raqam kriting");
        var palodrome = Int32.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine(FizzBuzz.IsPalindrome(palodrome));
    }
}