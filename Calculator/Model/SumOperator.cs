// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// Token for the sum operator '+'.
/// </summary>
public class SumOperator: Operator
{
   public override string ToString() => "+";
   
   /// <summary>
   /// Takes two doubles and adds them together.
   /// </summary>
   /// <param name="left"> A double. </param>
   /// <param name="right"> A double. </param>
   /// <returns> Right added to left. </returns>
   protected override double Calculate(double left, double right) => left + right;
}