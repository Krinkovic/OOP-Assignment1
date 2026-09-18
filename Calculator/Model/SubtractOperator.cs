namespace Calculator.Model;

public class SubtractOperator : Operator
{
    public override string ToString() => "-";
    public override double evaluate(double left, double right) => left - right;
}