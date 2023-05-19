using ICalculatorNamespace;

namespace ExtensionMethodsNamespace;

public static class MyExtensions
{

    public static int Subtract(this ICalculator calculator, int a, int b)
    {
        return a - b;
    }
}