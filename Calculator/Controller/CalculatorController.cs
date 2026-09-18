namespace Calculator.Controller;

public class CalculatorController
// Model: classes associated with the domain (logic and data),
// which in this case is the actual calculator with its tokens,
// stack, calculations, etc.
{
   public void Run(string[] args)
   {
      string? input = "";
      do
      {
         if (!String.IsNullOrEmpty(input))
         {
            args =  input.Split(" "); 
         }
         if (args.Length == 2)
         {
            // TODO: Add actions for initial arguments
         }
         else if (args.Length == 0)
         {
            Console.WriteLine("Enter an RPN expression <return> (empty string = exit):");
         }
         else
         {
            Console.WriteLine(
               "Incorrect number of arguments.\nEnter an RPN expression <return> (empty string = exit):");
         }

         input = Console.ReadLine();
      } while (input != "");

      Console.WriteLine("The user exited the application.");
      Environment.Exit(0);
   }
}