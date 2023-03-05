using DecoratorPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        IBeverage beverage = new Esperso();
        beverage = new Esperso();
        Console.WriteLine($"The cost of esperso is {beverage.Cost()}"); 

        IBeverage beverageCaramelEsperso = new Esperso();
        beverageCaramelEsperso = new CaramelDecorator(beverageCaramelEsperso);
        Console.WriteLine($"The cost of esperso caramel is {beverageCaramelEsperso.Cost()}");

        Console.ReadLine();
    }
}