internal class Program
{
    class model
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    private static void Main(string[] args)
    {
        var dic = new Dictionary<int, List<model>>();
        dic[15] = new List<model>(){
            new model{
                Id = 15,
                Name = "mohamed"
            },
             new model{
                Id = 16,
                Name = "ali"
            }
        };
        Console.WriteLine(dic[15][1].Name);

        /*  var inputs = Console.ReadLine().Split(" ");
          int cakes = int.Parse(inputs[0]);//599
          int TimePerOven = int.Parse(inputs[1]);//97
          int NoCakePerTime = int.Parse(inputs[2]);//54
          int TimeOfBuildOven = int.Parse(inputs[3]);//992
          // 2 --> 1
          var timeRequiredByOven = Math.Ceiling((double)(Math.Ceiling((double)TimePerOven / NoCakePerTime) * cakes));

          Console.WriteLine(timeRequiredByOven);
          int different = TimePerOven + TimeOfBuildOven;
          Console.WriteLine(different);

          if (timeRequiredByOven > different)
              Console.WriteLine("YES");
          else
              Console.WriteLine("NO");*/
    }
}