// 2026 Kristoffer Forsberg
using Calculator.Exceptions;

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

    /// <summary>
    /// Evaluates a string using RPN (Reverse Polish Notation) and returns the result.
    /// </summary>
    /// <param name="input"> A space-separated string of symbols, either doubles or one of the basic mathematical operators. </param>
    /// <returns> The result of the mathematical evaluation. </returns>
    /// <exception cref="MyInvalidTokenException"> When a token does not belong to one of the above groups. </exception>
    /// <exception cref="MyInvalidOperationException"> When the proper order of operations is not followed. </exception>
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
                        throw new MyInvalidTokenException(symbol);
                    }
                    
                    _stack.Push(new Operand(operand));
                    break;
            }
        }

        // 3 4 + 5 6 + *
        Token token = _stack.Pop();
        double result = token.Evaluate(_stack);

        if (_stack.Count != 0)
        {
            throw new MyInvalidOperationException();
        }
        return result;
    }
}
