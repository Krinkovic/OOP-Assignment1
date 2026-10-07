namespace Calculator.Exceptions;

public class DivideByZeroException(double dividend, string operatorSymbol)
   : Exception($"Division by zero: {dividend}{operatorSymbol}0.00")
{
   private double  Dividend { get; } = dividend;
   private string OperatorSymbol { get; } = operatorSymbol;
}