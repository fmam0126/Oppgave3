using System.Configuration.Assemblies;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using Spectre.Console;
using Spectre.Console.Rendering;

public class Calculate
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static double Sum(double a, double b)
    {
        return a + b;
    }
    public static int Minus(int a, int b)
    {
        return a - b;
    }
    public static double Minus(double a, double b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    public static double Divide(double a, double b)
    {
        return a / b;
    }
    public bool CalculateNumbers(string firstInput, string secondInput, string calculatorOperator)
    {
        switch (calculatorOperator)
        {
            case "+":
                {
                    if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    {
                        Ui.WriteResult(Calculate.Sum(firstNumber, secondNumber));
                        
                        //AnsiConsole.WriteLine(Calculate.Sum(firstNumber, secondNumber));
                        return true;
                    }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        Ui.WriteResult(Calculate.Sum(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            case "-":
                {
                    if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    {
                        Ui.WriteResult(Calculate.Minus(firstNumber, secondNumber));
                        return true;
                    }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        Ui.WriteResult(Calculate.Minus(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            case "*":
                {
                    if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    {
                        Ui.WriteResult(Calculate.Multiply(firstNumber, secondNumber));
                        return true;
                    }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        Ui.WriteResult(Calculate.Multiply(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            case "/":
                {
                    // if (int.TryParse(firstInput, out int firstNumber) && int.TryParse(secondInput, out int secondNumber))
                    // {
                    //     Ui.WriteResult(Calculate.Divide(firstNumber, secondNumber));
                    //     return true;
                    // }
                    if (double.TryParse(firstInput, out double firstDoubleNumber) && double.TryParse(secondInput, out double secondDoubleNumber))
                    {
                        if (firstDoubleNumber == 0 || secondDoubleNumber == 0)
                        {
                            Ui.DivideByZeroWarning();
                            return false;
                        }
                        Ui.WriteResult(Calculate.Divide(firstDoubleNumber, secondDoubleNumber));
                        return true;
                    }
                    return false;
                }
            default:
                return false;
        }
    }
}