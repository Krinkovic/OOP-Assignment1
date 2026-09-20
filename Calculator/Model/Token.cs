using System.Data;

namespace Calculator.Model;

public abstract class Token
{
   public abstract double? Evaluate(ITokenStack stack);
}