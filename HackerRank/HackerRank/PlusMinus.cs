namespace HackerRank;

public static class PlusMinus
{
    public static void Execute()
    {
        Console.WriteLine("Plus Minus");

        int n = Convert.ToInt32(Console.ReadLine()
                                       .Trim());

        List<int> arr = Console.ReadLine()
                               .TrimEnd()
                               .Split(' ')
                               .ToList()
                               .Select(arrTemp => Convert.ToInt32(arrTemp))
                               .ToList();

        PlusMinusSolution(arr);
    }

    public static void PlusMinusSolution(List<int> arr)
    {
        decimal arraySize = arr.Count;
        decimal positivesCount = 0;
        decimal negativessCount = 0;
        decimal zerosCount = 0;

        arr.ForEach(item => {
            if (item > 0) positivesCount++;
            if (item < 0) negativessCount++;
            if (item == 0) zerosCount++;
        });

        Console.WriteLine($"{positivesCount / arraySize:F6}");
        Console.WriteLine($"{negativessCount / arraySize:F6}");
        Console.WriteLine($"{zerosCount / arraySize:F6}");
    }
}
