internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        int i = 0;
        for (i = 1; true; i++)
        {

            if ((i * int.Parse(input[0]) % 10) == int.Parse(input[1]) || (i * int.Parse(input[0]) % 10) == 0)
            {
                break;
            }
        }
        Console.WriteLine(i);
    }
}