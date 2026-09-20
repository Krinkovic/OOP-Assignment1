namespace Calculator.Exceptions;

public class DivideByZeroException : Exception
{
   public double?  Dividend { get; }
   public string OperatorSymbol { get; }

   public DivideByZeroException(double? dividend, string operatorSymbol) : base($"Division by zero: {dividend} {operatorSymbol} 0")
   {
      Dividend = dividend;
      OperatorSymbol = operatorSymbol;
   }
}