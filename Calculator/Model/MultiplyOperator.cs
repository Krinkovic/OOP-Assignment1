namespace Calculator.Model;

public class MultiplyOperator : Operator
{
    public override string ToString() => "*";
    protected override double? Calculate(double? left, double? right) => left * right;
}