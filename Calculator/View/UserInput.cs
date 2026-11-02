namespace Calculator.View;

public class UserInput : IInput
{
    public string? GetNextInput() => Console.ReadLine();
}