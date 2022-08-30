// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        var orangesSize = Console.ReadLine().Split(" ");
        int ornagesNum = int.Parse(input[0]);
        int maxOrangeSize = int.Parse(input[1]);
        int maxJuicerTank = int.Parse(input[2]);
        int emptiesTankNumber = 0;
        int currentTank = 0;
        for (int i = 0; i < ornagesNum; i++)
        {
            if (maxOrangeSize < int.Parse(orangesSize[i]))
                continue;
            if ((currentTank + int.Parse(orangesSize[i]) <= maxJuicerTank))
            {
                currentTank += int.Parse(orangesSize[i]);
            }
            else
            {
                emptiesTankNumber++;
                currentTank = 0;
            }

        }
        Console.WriteLine(emptiesTankNumber);

    }
}