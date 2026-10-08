// 2026 Kristoffer Forsberg
namespace Calculator.Exceptions;

public class MyInvalidTokenException(string token) : Exception($"InvalidTokenException: {token}")
{
    private string Token { get; } = token;
}

