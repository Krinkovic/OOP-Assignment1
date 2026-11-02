namespace Calculator.View;

public interface IOutput
{
	void ShowResult(double? result);
	void ShowError(Exception ex);
}