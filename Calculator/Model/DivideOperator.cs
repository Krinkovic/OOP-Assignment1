// 2026 Kristoffer Forsberg

using Calculator.Exceptions;

namespace Calculator.Model;

/// <summary>
/// Token for the division operator '/'.
/// </summary>
public class DivideOperator : Operator
{
    public override string ToString() => "/";

    /// <summary>
    /// Takes two doubles and divides one with the other.
    /// </summary>
    /// <param name="left"> The numerator. </param>
    /// <param name="right"> The denominator. </param>
    /// <returns> The result of dividing left with right. </returns>
    /// <exception cref="MyDivideByZeroException"> If the denominator is 0. </exception>
    protected override double Calculate(double left, double right)
    {
        if (right == 0)
        {
            throw new MyDivideByZeroException(left, "/");
        }
        return left / right;
    }
}