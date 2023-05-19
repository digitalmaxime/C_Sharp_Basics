using CalculatorNamespace;
using ICalculatorNamespace;
using ExtensionMethodsNamespace;
internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Calculator calc = new Calculator();

        var res = calc.Subtract(1, 2);

        var res2 = MyExtensions.Subtract(calc, 1, 2);

        System.Console.WriteLine($"Res : {res2}");
        System.Console.WriteLine();
    }
}