using System.IO.Compression;

namespace Calculator.Model;

public class SumOperator: Operator
{
   public override string ToString() => "+";
   protected override double Calculate(double left, double right) => left + right;
}