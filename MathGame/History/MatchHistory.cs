namespace MathGame.History;

public static class MatchHistory
{
    private static List<Match> _historyList { get; set; }= new List<Match>();

    public static void AddMatch(Match match)
    {
        match.Id = _historyList.Count + 1;
        _historyList.Add(match);
    }
    
    public static void DisplayHistory()
    {
        foreach (var match in _historyList)
        {
            Console.Write($"#{match.Id}".PadRight(16));
            Console.Write($"{match.Mode}".PadRight(16));
            Console.Write($"{match.Score} out of 5".PadRight(16));
            Console.WriteLine();
        }
    }
}