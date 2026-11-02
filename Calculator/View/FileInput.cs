using System.IO;
namespace Calculator.View;

public class FileInput : IInput, IDisposable
{
    private readonly StreamReader _reader;

    public FileInput(FileInfo inputFile)
    {
        _reader = new StreamReader(inputFile.FullName);
    }
    public string? GetNextInput()
    {
        return _reader.ReadLine();
    }
    public void Dispose()
    {
        _reader.Dispose();
    }
}