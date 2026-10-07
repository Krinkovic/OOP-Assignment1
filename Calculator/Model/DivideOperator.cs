using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;
namespace Calculator.Model;

public class DivideOperator : Operator
{
    public override string ToString() => "/";

    protected override double Calculate(double left, double right)
    {
        if (right == 0)
        {
            throw new DivideByZeroException(left, "/");
        }
        return left / right;
    }
}