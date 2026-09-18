namespace Calculator.Model;

public abstract class Operator : Token
{
   public abstract double evaluate(double left, double right);
}