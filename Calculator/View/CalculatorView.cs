using System.IO;

namespace Calculator.View;



public class CalculatorView
// Namespace Calculator.View should contain all C# classes associated with the user
// interface, i.e. input of RPN strings from the user, and presentation of results and error
// messages to the user.
{

    // Read input from user.
    public string ReadInput()
    {
        UserInput inputReader = new UserInput();
        Console.WriteLine("Enter an RPN expression <return> (empty string = exit):");
        return inputReader.GetNextInput();
    }
    // Print text to the user.
    public void WriteToScreen(double? result)
    {
        UserOutput outputWriter = new UserOutput();

        outputWriter.ShowResult(result);
    }
    public void WriteToScreen(Exception ex)
    {
        UserOutput outputWriter = new UserOutput();
        outputWriter.ShowError(ex);
    }
    public void WriteToScreen()
    {
        UserOutput outputWriter = new UserOutput();
        outputWriter.ShowExitMessage();
    }
    public FileInput CreateFileReader(string[] args)
    {
        FileInfo inputFile = new FileInfo(args[0]);
        if (!inputFile.Exists)
        {
            throw new FileNotFoundException($"The file '{args[0]}' does not exist.");
        }
        return new FileInput(inputFile);
    }
    //Read input from file.
    public string ReadInput(FileInput fileInputReader)
    {
        return fileInputReader.GetNextInput();
    }
    // Print text to the file.
    public void WriteToFile(double? result, string[] args)
    {
        FileInfo outputFile = new FileInfo(args[1]);
        FileOutput outputWriter = new FileOutput(outputFile);

        outputWriter.ShowResult(result);
    }
    public void WriteToFile(Exception ex, string[] args)
    {
        FileInfo outputFile = new FileInfo(args[1]);
        FileOutput outputWriter = new FileOutput(outputFile);
        outputWriter.ShowError(ex);
    }
}

