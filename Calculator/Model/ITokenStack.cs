// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// Interface for the stack, enabling easy switching of implementation.
/// </summary>
public interface ITokenStack
{
   void Push(Token token);
   Token Pop();
   int  Count { get; }
   bool IsEmpty { get; }
}