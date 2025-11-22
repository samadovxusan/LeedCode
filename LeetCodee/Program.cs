using LeetCodee.Problems;
using LeetCodee.Problems.LinkedList;
using LeetCodee.Problems.Sorting;

namespace LeetCodee;

class Program
{
    static void Main(string[] args)
    {
        var nums = new LinkedList<int>();
        nums.AddLast(1);
        nums.AddLast(5);
        nums.AddLast(7);
        nums.AddLast(22);
        nums.AddLast(44);




        Console.WriteLine(Example.FindTarget(nums));
    }
}