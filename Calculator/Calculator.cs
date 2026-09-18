using Calculator.Controller;

namespace Calculator
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
