// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// Token for the subtraction operator '-'.
/// </summary>
public class SubtractOperator : Operator
{
    public override string ToString() => "-";
    
    /// <summary>
    /// Takes two doubles and subtracts one from the other.
    /// </summary>
    /// <param name="left"> A double. </param>
    /// <param name="right"> A double. </param>
    /// <returns> Right subtracted from left. </returns>
    protected override double Calculate(double left, double right) => left - right;
}