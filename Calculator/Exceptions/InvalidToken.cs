namespace Calculator.Exceptions;

public class InvalidToken(string token) : Exception($"InvalidTokenException: {token}")
{
    private string Token { get; } = token;
}

