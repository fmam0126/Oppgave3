public class Calculate
{
    /// <summary>
    /// Calculates the Math operation using the correct operator
    /// </summary>
    /// <param name="firstInput">First Number input</param>
    /// <param name="secondInput">Second Number input</param>
    /// <param name="calculatorOperator">What operator to use (+,-,*,/)</param>
    /// <returns>Returns True or False if the Math operation was successful or not</returns>
    public bool CalculateNumbers(string firstInput, string secondInput, string calculatorOperator)
    {
        switch (calculatorOperator)
        {
            case "+":
                {
                    if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    {
                        Ui.WriteResult(Operation.Sum(firstNumber, secondNumber));
                        
                        //AnsiConsole.WriteLine(Operation.Sum(firstNumber, secondNumber));
                        return true;
                    }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        Ui.WriteResult(Operation.Sum(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            case "-":
                {
                    if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    {
                        Ui.WriteResult(Operation.Minus(firstNumber, secondNumber));
                        return true;
                    }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        Ui.WriteResult(Operation.Minus(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            case "*":
                {
                    if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    {
                        Ui.WriteResult(Operation.Multiply(firstNumber, secondNumber));
                        return true;
                    }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        Ui.WriteResult(Operation.Multiply(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            case "/":
                {
                    // if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    // {
                    //     Ui.WriteResult(Operation.Divide(firstNumber, secondNumber));
                    //     return true;
                    // }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        if (firstDoubleNumber == 0 || secondDoubleNumber == 0)
                        {
                            Ui.DivideByZeroWarning();
                            return false;
                        }
                        Ui.WriteResult(Operation.Divide(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            default:
                return false;
        }
    }
}