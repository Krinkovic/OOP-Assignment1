// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// A token holding a numeric value.
/// </summary>
public class Operand : Token
{
   public Operand(double value) { Value = value; }
   public override double Evaluate(ITokenStack stack) => Value;

   private double Value { get; }
   public override string ToString() => Value.ToString();
}