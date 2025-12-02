using LeetCodee.OppExample;
using LeetCodee.Problems;
using LeetCodee.Problems.LinkedList;
using LeetCodee.Problems.Sorting;

namespace LeetCodee;

class Program
{
    static void Main(string[] args)
    {

        Dasturchi YangiDasturchi = new Dasturchi()
        {
            Name = "Husan",
            Age = 25,
            Til = "C#"
        };

        YangiDasturchi.UpdateMoash(100.000);

        Console.WriteLine($"{YangiDasturchi.Name}  {YangiDasturchi.Til}");
        YangiDasturchi.Tanishish();
        var result =  YangiDasturchi.GetMoash();
        Console.WriteLine($"mening Muoshim : {result}");


    }
}