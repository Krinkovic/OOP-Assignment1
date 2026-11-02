using System.IO;
namespace Calculator.View;

public class FileOutput : IOutput
{
    private readonly FileInfo _outputFile;

    public FileOutput(FileInfo outputFile) // constructor to initialize the output file
    {
        _outputFile = outputFile;
    }
    public void ShowResult(double? result)
    {
        using (StreamWriter writer = new StreamWriter(_outputFile.FullName, true))
        {
            writer.WriteLine($"Result: {result}");
        }
    }
    public void ShowError(Exception ex)
    {
        using (StreamWriter writer = new StreamWriter(_outputFile.FullName, true))
        {
            writer.WriteLine($"Error: {ex.Message}");
        }
    }
}
