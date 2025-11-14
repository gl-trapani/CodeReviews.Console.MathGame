using MathGame.GameModes;
using MathGame.History;

namespace MathGame.UserInterface;

public class UserInterface
{
    private GameMode _gameModeAdd = new Add();
    private GameMode _gameModeSubtract = new Subtract();
    private GameMode _gameModeMultiply = new Multiply();
    private GameMode _gameModeDivide = new Divide();

    public void MainMenu()
    {
        var choice = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Clear();
            Console.WriteLine("Choose challenge:");
            Console.WriteLine($"{(int)MainMenuOptions.Add} -\t {MainMenuOptions.Add}");
            Console.WriteLine($"{(int)MainMenuOptions.Subtract} -\t {MainMenuOptions.Subtract}");
            Console.WriteLine($"{(int)MainMenuOptions.Multiply} -\t {MainMenuOptions.Multiply}");
            Console.WriteLine($"{(int)MainMenuOptions.Divide} -\t {MainMenuOptions.Divide}");
            Console.WriteLine($"{(int)MainMenuOptions.History} -\t {MainMenuOptions.History}");
            Console.WriteLine($"{(int)MainMenuOptions.Quit} -\t {MainMenuOptions.Quit}");

            validInput = int.TryParse(Console.ReadLine(), out choice);
        }

        switch (choice)
        {
            case (int)MainMenuOptions.Add:
                _gameModeAdd.Play();
                _gameModeAdd.Save(Modes.Addition);
                break;
            case (int)MainMenuOptions.Subtract:
                _gameModeSubtract.Play();
                _gameModeSubtract.Save(Modes.Subtraction);
                break;
            case (int)MainMenuOptions.Multiply:
                _gameModeMultiply.Play();
                _gameModeMultiply.Save(Modes.Multiplication);
                break;
            case (int)MainMenuOptions.Divide:
                _gameModeDivide.Play();
                _gameModeDivide.Save(Modes.Division);
                break;
            case (int)MainMenuOptions.History:
                HistoryMenu();
                break;
            case (int)MainMenuOptions.Quit:
                Environment.Exit(0);
                break;
        }
    }

    private void HistoryMenu()
    {
        Console.Clear();
        Console.WriteLine("Match History");
        Console.Write("Match".PadRight(16));
        Console.Write("Mode".PadRight(16));
        Console.Write("Score".PadRight(16) + "\n");

        MatchHistory.DisplayHistory();

        Console.WriteLine();
        Console.Write("Press <Enter> to return to the main menu... ");
        Console.ReadLine();
    }
}