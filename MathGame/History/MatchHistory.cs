namespace MathGame.History;

public static class MatchHistory
{
    private static List<Match> HistoryList { get; set; }= new List<Match>();

    public static void AddMatch(Match match)
    {
        match.Id = HistoryList.Count + 1;
        HistoryList.Add(match);
    }
    
    public static void DisplayHistory()
    {
        foreach (var match in HistoryList)
        {
            Console.Write($"#{match.Id}".PadRight(16));
            Console.Write($"{match.Mode}".PadRight(16));
            Console.Write($"{match.Score} out of 5".PadRight(16));
            Console.WriteLine();
        }
    }
}