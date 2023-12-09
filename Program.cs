using System.Data;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        string filepath = @"calculate.txt";

        var results = new List<object>();
        try
        {
            string[] problems = File.ReadAllLines(filepath);
            Console.WriteLine("Results: ");
            foreach(var problem in problems)
            {
                var result = Convert.ToDouble(new DataTable().Compute(problem, null));
                results.Add(result);
                Console.WriteLine($"{problem} = {result}");
            }
        }
        catch(Exception)
        {
            Console.WriteLine("File not found!");
        }
        Console.WriteLine();
        double sum = 0;
        foreach(double result in results)
        {
            sum += result;
        }
        Console.WriteLine($"Total entries: {results.Count}");
        Console.WriteLine($"Total amount: {sum}");
    }
}