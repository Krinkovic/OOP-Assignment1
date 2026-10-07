// 2026 Kristoffer Forsberg
namespace Calculator.Model;

/// <summary>
/// A token acting as an arithmetic operator: +, -, *, / or %.
/// </summary>
public abstract class Operator : Token
{
    public override double Evaluate(ITokenStack stack)
    {
        double left = stack.Pop().Evaluate(stack);
        double right = stack.Pop().Evaluate(stack);
        return Calculate(left, right);
    }
    protected abstract double Calculate(double left, double right);
}