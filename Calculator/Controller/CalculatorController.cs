namespace Calculator.Controller;

public class CalculatorController
// Namespace Calculator.Controller should contain a class CalculatorController that
// drives the actual application. Furthermore, this class ensures that the model-classes
// are separated from the view-classes, i.e. no model-class should know about (have an
// association to) any view-class, and no view-class should know about (have an association
// to) a model-class. Only the CalculatorController class should know about model-classes
// and view-classes.
{
   // This runs when no startup arguments are passed. Then we need to get input from the user.
   // Call the View to get user input. Send that input to the Model.
   // The Model calculates the result and returns it here.
   // Pass the result to the View. The View presents the results on the screen for the user.
   public void Run()
   {
      throw new NotImplementedException();
   }
   
   // args is a list containing an input and output file: [input.txt, output.txt].
   // This method needs to read the input file, and send one line at a time to the Model.
   // The Model calculates a result for the line and returns it.
   // This method then writes the result to the output file.
   public void Run(string[] args)
   {
      throw new NotImplementedException();
   }
}