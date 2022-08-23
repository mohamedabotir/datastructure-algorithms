

internal class Program
{
    private static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());

        int[,] teamsSets = new int[input, 2];
        int changes = 0;
        for (var i = 0; i < input; i++)
        {
            var data = Console.ReadLine().Split(' ');
            teamsSets[i, 0] = int.Parse(data[0]);

            teamsSets[i, 1] = int.Parse(data[1]);

        }




        for (var i = 0; i < input; i++)
        {
            for (var j = 0; j < input; j++)
            {
                if (i == j)
                    continue;
                if (teamsSets[i, 0] == teamsSets[j, 1])
                    changes++;
            }
        }
        Console.WriteLine(changes);

    }
}