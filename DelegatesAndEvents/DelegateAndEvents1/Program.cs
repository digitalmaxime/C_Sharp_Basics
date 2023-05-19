namespace DelegateDemo;

public class Program {
    static int Square(int input) => input * input;

    static void Main(string[] args) {

        var calculator = new Calculator();
        
        // DELEGATE
        var response = calculator.Execute(Square, 5);
        System.Console.WriteLine($"Main program DELEGATE, response : {response}");
        
        // FUNC
        var response2 = calculator.ExecuteFunc(Square, 5);
        System.Console.WriteLine($"Main program FUNC, response : {response2}");
        
        // ACTION
        System.Console.Write($"Main program ACTION, response : ");
        var response3 = calculator.ExecuteAction(Square, System.Console.WriteLine, 5);
        
        // LAMBDA
        var response4 = calculator.Execute((int x) => x * x, 5);
        System.Console.WriteLine($"Main program LAMBDA, response : {response4}");


        // EVENT
        calculator.CalculateEvent += (obj, args) => System.Console.WriteLine(args.Name);;
        calculator.RaiseEvent("Test Event 1");

    }
}