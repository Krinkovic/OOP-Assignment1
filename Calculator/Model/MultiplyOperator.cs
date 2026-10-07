// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// Token for the multiplication operator '*'.
/// </summary>
public class MultiplyOperator : Operator
{
    public override string ToString() => "*";
    
    /// <summary>
    /// Multiplies two doubles.
    /// </summary>
    /// <param name="left"> First factor. </param>
    /// <param name="right"> Second factor. </param>
    /// <returns> The product of left and right. </returns>
    protected override double Calculate(double left, double right) => left * right;
}