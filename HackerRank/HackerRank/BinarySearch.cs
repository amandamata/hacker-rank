namespace HackerRank
{
    public static class BinarySearch
    {
        public static void Execute()
        {
            Console.WriteLine("Binary Search");
            BinarySearchSolution();   
        }

        public static void BinarySearchSolution()
        {
            Console.Write("array: ");
            List<int> arr = Console.ReadLine()
                               .TrimEnd()
                               .Split(' ')
                               .Select(arrTemp => Convert.ToInt32(arrTemp))
                               .ToList();

            Console.Write("target: ");
            int target = Convert.ToInt32(Console.ReadLine()
                                           .Trim());

            var start = 0;
            var end = arr.Count;

            Console.WriteLine(binarySearch(arr, target, start, end));
        }

        private static bool binarySearch(List<int> arr, int target, int start, int end)
        {
            var midIndex = Convert.ToInt32(Math.Floor(Convert.ToDouble((start + end) / 2)));

            Console.Write("> ");
            arr.Skip(start)
               .Take(end)
               .ToList()
               .ForEach(i => Console.Write("{0} ", i));
            
            Console.WriteLine("");

            if (start > end)
                return false;
            if (arr[midIndex] == target)
                return true;
            if (arr[midIndex] > target)
                return binarySearch(arr, target, start, midIndex - 1);
            else return binarySearch(arr, target, midIndex + 1, end);
        }
    }
}
