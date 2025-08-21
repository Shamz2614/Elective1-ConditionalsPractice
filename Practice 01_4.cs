using System;

class Practice04
{
    static void Main()
    {
        Console.Write("Enter your exam score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        string result = (score >= 50) ? "Passed" : "Failed";
        // I used the ternary operator to simplify the condition instead of writing an if-else block.
        Console.WriteLine(result);
    }
}
