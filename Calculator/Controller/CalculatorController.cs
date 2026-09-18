namespace Calculator.Controller;

public class CalculatorController
// Namespace Calculator.Controller should contain a class CalculatorController that
// drives the actual application. Furthermore, this class ensures that the model-classes
// are separated from the view-classes, i.e. no model-class should know about (have an
// association to) any view-class, and no view-class should know about (have an association
// to) a model-class. Only the CalculatorController class should know about model-
// classes and view-classes.
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