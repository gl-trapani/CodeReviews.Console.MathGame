namespace MathGame;

class Program
{
    static void Main()
    {
        UserInterface.UserInterface userInterface = new();
        while (true)
        {
            userInterface.MainMenu();
        }
    }
}