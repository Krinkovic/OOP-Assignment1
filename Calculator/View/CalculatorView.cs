namespace Calculator.View;

public class CalculatorView
// Namespace Calculator.View should contain all C# classes associated with the user
// interface, i.e. input of RPN strings from the user, and presentation of results and error
// messages to the user.
{
    // Read input from user.
    public string ReadInput()
    {
        throw new NotImplementedException();
    }

    // Print text to the user.
    public void WriteToScreen()
    {
        throw new NotImplementedException();
    }
}

/*
 Moved some code here that was mistakenly put into the Controller class.
 Put here if anyone wants to use it where it is supposed to be used.

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
*/
