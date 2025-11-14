namespace MathGame.GameModes;

public class Multiply : GameMode
{
    private int _value1;
    private int _value2;

    protected override void Prompt(Random random)
    {
        _value1 = random.Next(1, 10);
        _value2 = random.Next(1, 10);

        Console.WriteLine($"{_value1} x {_value2} = ?");
    }

    protected override bool Evaluate()
    {
        bool validInput = false;
        var result = 0;

        while (!validInput)
        {
            validInput = int.TryParse(Console.ReadLine(), out result);
        }
        
        return result == _value1 * _value2;
    }
}