// Main program
using System.Diagnostics;
using LightstoneAssessment;
using LightstoneAssessment.Interface;
using LightstoneAssessment.Service;

public class Program
{
    static void Main(string[] args)
    {

        IWordReverser reverser = new WordReverser();
        Console.WriteLine("Enter the number of test cases (N):");

        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("Invalid number of test cases.");
            return;
        }

        Console.WriteLine("For each test case, enter a line of space-separated words:");
        var inputs = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Input for case {i}: ");
            string line = Console.ReadLine();
            if (line == null)
            {
                Console.WriteLine($"Missing input for case {i}.");
                break;
            }
            inputs.Add(line);
        }

        var outputs = new List<string>();

        for (int i = 0; i < inputs.Count; i++)
        {
            string reversed = reverser.ReverseWords(inputs[i]);
            outputs.Add($"case{i + 1}: {reversed}");
        }

        Console.WriteLine("\nOutput:");
        foreach (var output in outputs)
        {
            Console.WriteLine(output);
        }

        //ITestCaseProcessor processor = new TestCaseProcessor(reverser);
        // UnitTests.RunAll();
    }
}
