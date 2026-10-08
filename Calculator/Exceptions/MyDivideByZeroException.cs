// 2026 Kristoffer Forsberg
namespace Calculator.Exceptions;

public class MyDivideByZeroException(double dividend, string operatorSymbol)
   : Exception($"Division by zero: {dividend:F2}{operatorSymbol}0.00")
{
   private double  Dividend { get; } = dividend;
   private string OperatorSymbol { get; } = operatorSymbol;
}