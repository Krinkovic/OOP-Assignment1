namespace Calculator.View;

public class UserOutput : IOutput
{
    public void ShowResult(double? result)
    {
        Console.WriteLine($"Result: {result:F2}");
    }
    public void ShowError(Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    public void ShowExitMessage()
    {
        Console.WriteLine("Exiting the calculator. Goodbye!");
        Console.ReadLine();
    }
}
