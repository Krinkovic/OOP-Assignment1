namespace Calculator.Exceptions;

public class InvalidTokenException(string token) : Exception($"InvalidTokenException: {token}")
{
    private string Token { get; } = token;
}

