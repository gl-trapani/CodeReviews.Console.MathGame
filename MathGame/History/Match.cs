using MathGame.GameModes;
namespace MathGame.History;

public class Match
{
    public int Id { get; set; } = 0;
    public Modes Mode { get; set; }
    
    public int Score { get; set; } = 0;
    
    public Match(Modes gameMode, int score)
    {
        Mode = gameMode;
        Score = score;
    }
}