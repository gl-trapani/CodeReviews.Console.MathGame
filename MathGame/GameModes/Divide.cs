namespace MathGame.GameModes;

public class Divide : GameMode
{
    private int _value1;
    private int _value2;

    protected override void Prompt(Random random)
    {
        do
        {
            _value1 = random.Next(2, 20);
            _value2 = random.Next(2, _value1);

        } while (_value1 % _value2 != 0);

        Console.WriteLine($"{_value1} / {_value2} = ?");
    }

    protected override bool Evaluate()
    {
        bool validInput = false;
        var result = 0;

        while (!validInput)
        {
            validInput = int.TryParse(Console.ReadLine(), out result);
        }

        return result == _value1 / _value2;
    }
}