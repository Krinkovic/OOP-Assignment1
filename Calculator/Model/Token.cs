// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// The base token class.
/// </summary>
public abstract class Token
{
   public abstract double Evaluate(ITokenStack stack);
}