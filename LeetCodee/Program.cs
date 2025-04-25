using LeetCodee;

class Program
{
    static void Main(string[] args)
    {
        var sum = SpiralMatrix.GenerateMatrix(3);
        foreach (var index in sum)
        {
            foreach (var item in index)
            {
                Console.WriteLine($"{ item}  ");
            }
        }


    }
}