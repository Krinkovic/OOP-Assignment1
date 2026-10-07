using Calculator.Exceptions;
using DivideByZeroException =  Calculator.Exceptions.DivideByZeroException;
using InvalidOperationException = Calculator.Exceptions.InvalidOperationException;

namespace Calculator.Model;

public class CalculatorModel
// Namespace Calculator.Model should contain all C# classes associated with the domain,
// i.e. that have to do with the calculator’s logic and data (calculations, tokens, the stack,
// etc.).
{
    private readonly ITokenStack _stack;
    public CalculatorModel(ITokenStack stack)
    {
        _stack = stack;
    }

    // Takes a string line and converts to individual operators/operands and pushes each one to the stack
    public double Evaluate(string input)
    {
        string[] symbols = input.Split(" ");
        
        foreach (string symbol in symbols)
        {
            switch (symbol)
            {
                case "+":
                    _stack.Push(new SumOperator());
                    break;
                case "-":
                    _stack.Push(new SubtractOperator());
                    break;
                case "*":
                    _stack.Push(new MultiplyOperator());
                    break;
                case "/":
                    _stack.Push(new DivideOperator());
                    break;
                case "%":
                    _stack.Push(new ModulusOperator());
                    break;
                default:
                    double operand;
                    try
                    {
                        operand = double.Parse(symbol);
                    }
                    catch (FormatException)
                    {
                        throw new InvalidTokenException(symbol);
                    }
                    
                    _stack.Push(new Operand(operand));
                    break;
            }
        }

        // 3 4 + 5 6 + *
        Token token = _stack.Pop();
        double result = token.Evaluate(_stack);

        if (_stack.Count == 0)
        {
            return result;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }
}
