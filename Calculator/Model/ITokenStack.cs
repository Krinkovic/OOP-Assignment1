namespace Calculator.Model;

public interface ITokenStack
{
   void Push(Token token);
   Token Pop();
   int  Count { get; }
   bool IsEmpty { get; }
}