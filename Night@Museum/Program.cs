internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();
        int moves = 0;
        int start = 0;

        for (var i = 0; i < input.Length; i++)
        {
            int index = input[i] - 97;
            int difference = Math.Abs(start - index);
            if (difference < 13)
            {
                moves += difference;
            }
            else
            {
                moves += 26 - difference;
            }
            start = index;
        }

        Console.WriteLine(moves);
    }
}