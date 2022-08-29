internal class App
{
    private static void Main(string[] args)
    {
        addNumbers(2, 8);
    }
    static void showMsgByConsole(string msg)
    {
        Console.WriteLine(msg);
    }
    static void addNumbers(int num1,int num2)
    {
        int sumResult = num1 + num2;
        string msg = $"{num1} + {num2} = {sumResult}";
        showMsgByConsole(msg);
    }
}