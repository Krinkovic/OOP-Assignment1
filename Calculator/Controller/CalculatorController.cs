using System.Data;
using Calculator.Model;
using Calculator.View;
using System.IO;

namespace Calculator.Controller;

public class CalculatorController
// Namespace Calculator.Controller should contain a class CalculatorController that
// drives the actual application. Furthermore, this class ensures that the model-classes
// are separated from the view-classes, i.e. no model-class should know about (have an
// association to) any view-class, and no view-class should know about (have an association
// to) a model-class. Only the CalculatorController class should know about model-classes
// and view-classes.
{
   private ITokenStack _stack = new TokenStack();
   // This runs when no startup arguments are passed. Then we need to get input from the user.
   // Call the View to get user input. Send that input to the Model.
   // The Model calculates the result and returns it here.
   // Pass the result to the View. The View presents the results on the screen for the user.
   public void Run()
    {
        CalculatorModel model = new CalculatorModel(_stack);
        CalculatorView view = new CalculatorView();

        while (true)
        {
            try
            {
                string input = view.ReadInput();
                if (string.IsNullOrWhiteSpace(input))
                {
                    view.WriteToScreen();
                    break;
                }
                double result = model.Evaluate(input);
                view.WriteToScreen(result);
            }
            catch (Exception ex)
            {
                view.WriteToScreen(ex);
                _stack = new TokenStack();
                model = new CalculatorModel(_stack);

            }
        }
   }
   
   // args is a list containing an input and output file: [input.txt, output.txt].
   // This method needs to read the input file, and send one line at a time to the Model.
   // The Model calculates a result for the line and returns it.
   // This method then writes the result to the output file.
   public void Run(string[] args)
    {
        CalculatorModel model = new CalculatorModel(_stack);
        CalculatorView view = new CalculatorView();
        FileInput fileInputReader = view.CreateFileReader(args);

        while (true)
        {
            try
            {
                string input = view.ReadInput(fileInputReader);
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                double result = model.Evaluate(input);
                view.WriteToFile(result, args);
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
                view.WriteToFile(ex, args);
                _stack = new TokenStack();
                model = new CalculatorModel(_stack);

            }
        }
        fileInputReader.Dispose();
    }
}