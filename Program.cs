using Spectre.Console;

namespace Oppgave3;

class Program
{
    static void Main(string[] args)
    {
        do
        {

            Calculate calculate = new Calculate();
            string firstInput = Ui.AskForFirstNumber();
            string calculatorOperator = Ui.ChooseOperator();
            string secondInput = Ui.AskForSecondNumber();

            if (!calculate.CalculateNumbers(firstInput, secondInput, calculatorOperator))
            {
                AnsiConsole.WriteLine("Enter a valid input");
            }
            string exitInput = Ui.AskForExit();
            if (exitInput == "No")
            {

                break;

            }
        } while (true);



        // Calculate calculate = new Calculate();
        // double firstNumber = 0;
        // double secondNumber = 0;
        // double total = 0;

        // while (true)
        // {
        //     Console.Clear();
        //     Console.WriteLine("Welcome to Calculating Calculator 9000");
        //     Console.WriteLine("Enter the first number");
        //     string? firstInput = Console.ReadLine();

        //     Console.WriteLine("Enter The Operator ( + , - , * , / )");
        //     string? calculatorOperator = Console.ReadLine();

        //     Console.WriteLine("Enter the Second number");
        //     string? secondInput = Console.ReadLine(); 
        //     switch (calculatorOperator)
        //     {
        //         case "+":  
        //         double.TryParse(firstInput, out firstNumber);
        //         double.TryParse(secondInput, out secondNumber);
        //         total = calculate.sum(firstNumber, secondNumber);
        //         break;
        //         default:
        //         Console.WriteLine("Please enter a valid operator");
        //         break;
        //     }
        //     Console.WriteLine("The result is :");
        //     Console.WriteLine(total);

        //     Console.WriteLine("Press Enter to continue or type exit to exit");
        //     string? readResult = Console.ReadLine();
        //     if (readResult!.Trim().ToLower() == "exit")
        //     {
        //         break;
        //     }
        // }
    }
}
