using DivideByZeroException = Calculator.Exceptions.DivideByZeroException;
namespace Calculator.Model;

public class DivideOperator : Operator
{
    public override string ToString() => "/";

    protected override double? Calculate(double? left, double? right)
    {
        try
        {
            if (right == 0)
            {
                throw new DivideByZeroException(left, "/");
            }
            return left / right;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        return null;
    }
}