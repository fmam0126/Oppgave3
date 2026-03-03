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
}