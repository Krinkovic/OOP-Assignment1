namespace Calculator.Model;

public class MultiplyOperator : Operator
{
    public override string ToString() => "*";
    public override double evaluate(double left, double right) => left * right;
}