internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        var input1 = int.Parse(input[0]);
        var input2 = long.Parse(input[1]);//initialize ice value
        var distress = 0;
        for (var i = 0; i < input1; i++)
        {
            var carrier = Console.ReadLine();
            var split = carrier.Split(' ');
            if (split[0] == "+")
            {
                input2 += int.Parse(split[1]);
            }
            else if (split[0] == "-")
            {
                if (input2 >= int.Parse(split[1]))
                    input2 -= int.Parse(split[1]);
                else
                    distress++;
            }
        }
        Console.WriteLine(input2 + " " + distress);
    }
}