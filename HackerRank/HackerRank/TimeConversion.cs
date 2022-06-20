
namespace HackerRank
{
    public static class TimeConversion
    {
        public static void Execute()
        {
            Console.WriteLine("Time Conversion");

            string s = Console.ReadLine();
            string result = TimeConversionSolution(s);
            Console.WriteLine(result);
        }

        public static string TimeConversionSolution(string s)
        {
            var sSplit = s.Split(":");
            var twelveFormatTime = Convert.ToInt32(sSplit[0]);
            var twentyFourTime = "";

            if (sSplit[2].Contains("PM"))
            {
                twentyFourTime = twelveFormatTime == 12 ? twelveFormatTime.ToString() : (twelveFormatTime + 12).ToString();
            }

            if (sSplit[2].Contains("AM"))
            {
                twentyFourTime = twelveFormatTime == 12 ? "00" : $"0{twelveFormatTime}";
            }

            return $"{twentyFourTime}:{sSplit[1]}:{sSplit[2].Replace("PM","").Replace("AM","")}";
        }
    }
}
