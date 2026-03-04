using Microsoft.VisualBasic;
using Spectre.Console;

public static class Ui
{
    public static string AskForFirstNumber()
    {
        AnsiConsole.Clear();
        return AnsiConsole.Ask<string>("[green]Please Enter The First number: [/]\n");
    }
    public static string AskForSecondNumber()
    {
        AnsiConsole.Clear();
        return AnsiConsole.Ask<string>("Please Enter The Second number: \n");
    }
    public static string ChooseOperator()
    {
        AnsiConsole.Clear();
        return AnsiConsole.Prompt(new SelectionPrompt<string>().Title("Please Select the operator:").AddChoices("+","-","*","/"));
    }
    public static string AskForExit()
    {
        
        return AnsiConsole.Prompt(new SelectionPrompt<string>().Title("Do You Want to Continue?").AddChoices("Yes","No"));
    }
    public static void WriteResult(int result)
    {
        AnsiConsole.Clear();
        AnsiConsole.WriteLine("The result is: ");
        AnsiConsole.WriteLine(result);
    }
        public static void WriteResult(double result)
    {
        AnsiConsole.Clear();
        AnsiConsole.WriteLine("The result is: ");
        AnsiConsole.WriteLine(result);
    }
        public static void DivideByZeroWarning()
    {
        AnsiConsole.Clear();
        AnsiConsole.WriteLine("You Cant Divide by zero");
    }

}