using MathGame.History;

namespace MathGame.GameModes;


public abstract class GameMode
{
    private Random _random = new();
    public int Score { get; set; }
    public int Round { get; set; } = 1;
    public int MaxRound { get; set; } = 5;
    
    public void Play()
    {
        Round = 1;
        Score = 0;
        
        while (Round <= MaxRound)
        {
            Console.Clear();
            Console.WriteLine($"Score: {Score}");
            Console.WriteLine($"Round: {Round}/{MaxRound}");
            Prompt(_random);
            SetScore(Evaluate());
            Round++;
            if (Round > MaxRound)
                continue;
            Console.Write("Press <Enter> for the next round... ");
            Console.ReadLine();
        }
        Console.Write("Press <Enter> to return to the main menu... ");
        Console.ReadLine();
    }

    protected abstract void Prompt(Random random);
    protected abstract bool Evaluate();

    private void SetScore(bool answer)
    {
        if (answer)
        {
            Score++;
            Console.WriteLine("Correct answer!");
        }
        else
        {
            Console.WriteLine("Wrong answer!");
        }
    }

    public void Save(Modes gameMode)
    {
        Match match = new(gameMode, Score);
        MatchHistory.AddMatch(match);
    }
}