using MathGame.GameModes;
namespace MathGame.History;

public class Match
{
    public int Id { get; set; }
    public Modes Mode { get; set; }
    
    public int Score { get; set; }
    
    public Match(Modes gameMode, int score)
    {
        Mode = gameMode;
        Score = score;
    }
}