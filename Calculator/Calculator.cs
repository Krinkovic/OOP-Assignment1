using Calculator.Controller;

namespace Calculator
// Namespace Calculator should contain the application class Calculator (which was
// renamed from Program) which, in turn, contains the application’s Main() method.
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            CalculatorController ctr = new CalculatorController();
            ctr.Run(args);
        }
    }
}
