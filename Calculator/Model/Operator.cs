namespace Calculator.Model;

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