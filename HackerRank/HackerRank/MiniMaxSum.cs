namespace HackerRank;

public static class MiniMaxSum
{
    public static void Execute()
    {
        Console.WriteLine("Mini-Max Sum");

        List<int> arr = Console.ReadLine()
                               .TrimEnd()
                               .Split(' ')
                               .ToList()
                               .Select(arrTemp => Convert.ToInt32(arrTemp))
                               .ToList();
        
        MiniMaxSumSolution(arr);
        MiniMaxSumSolution2(arr);
    }

    public static void MiniMaxSumSolution(List<int> arr)
    {
        long total = 0;
        arr.ForEach(x =>
        {
            total += x;
        });

        var min = total - arr.LastOrDefault();
        var max = total - arr.FirstOrDefault();

        Console.WriteLine($"{ min } { max }");
    }

    public static void MiniMaxSumSolution2(List<int> arr)
    {
        long total = 0;
        var min = arr[0];
        var max = arr[0];

        foreach(var item in arr)
        {
            total += item;
            if (item > min) min = item;
            if (item < max) max = item;
        }

        Console.WriteLine($"{ total - min } { total - max }");
    }
}
