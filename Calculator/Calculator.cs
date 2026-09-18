using Calculator.Controller;

namespace Calculator
// Namespace Calculator should contain the application class Calculator (which was
// renamed from Program) which, in turn, contains the application’s Main() method.
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Environment.Exit(0);
            var controller = new CalculatorController();
            if (args.Length == 0)
            {
                controller.Run([]);
            }
            else if (args.Length == 2)
            // This should take all the arguments from an external file
            // and output the results in an external output file. 
            {
                controller.Run(args);
            }
            else
            {
                Console.WriteLine("Syntax: Calculator [source destination]");
                Environment.Exit(1);
            }
        }
    }
}
