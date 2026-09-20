namespace Calculator.Model;

public class TokenStack : ITokenStack
{
    private readonly Stack<Token> _stack = new Stack<Token>();
    public void Push(Token token) => _stack.Push(token);
    public Token Pop() => _stack.Pop();
    public int  Count => _stack.Count;
    public bool IsEmpty => _stack.Count == 0;
}