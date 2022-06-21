namespace HackerRank
{
    public static class ProcessLogs
    {
        public static void Execute()
        {
            Console.WriteLine("Process Logs");
            Console.Write("Array size: ");
            int logsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> logs = new List<string>();

            for (int i = 0; i < logsCount; i++)
            {
                Console.Write($"[{i}]: ");
                string logsItem = Console.ReadLine();
                logs.Add(logsItem);
            }

            Console.Write("Threshold: ");
            int threshold = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> result = Process(logs, threshold);
            
            result.ForEach(i => Console.Write("{0} ", i));

        }

        public static List<string> Process(List<string> logs, int threshold)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < 1; i++)
            {
                var iFirst = logs[i].Split(" ")[0];
                var iSecond = logs[i].Split(" ")[1];
                var iFirstThreshold = 1;
                var iSecondThreshold = 1;

                for (int j = i + 1; j < logs.Count; j++)
                {
                    var jFirst = logs[j].Split(" ")[0];
                    var jSecond = logs[j].Split(" ")[1];

                    if (iFirst == jFirst || iFirst == jSecond)
                        iFirstThreshold++;

                    if (iSecond == jFirst || iSecond == jSecond)
                        iSecondThreshold++;
                }
               
                if (iFirstThreshold >= threshold) result.Add(iFirst);
                if (iSecondThreshold >= threshold) result.Add(iSecond);
            }
            return result;
        }
    }
}
