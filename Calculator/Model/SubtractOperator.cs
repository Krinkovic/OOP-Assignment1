namespace Calculator.Model;

public class SubtractOperator : Operator
{
    public override string ToString() => "-";
    protected override double? Calculate(double? left, double? right) => left - right;
}