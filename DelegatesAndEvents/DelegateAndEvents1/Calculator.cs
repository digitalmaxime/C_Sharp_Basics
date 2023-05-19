using System.Runtime.InteropServices;

namespace DelegateDemo;

public class Calculator {

    /** Generic Delegate */
    public delegate int Calculate(int input);
    public int Execute(Calculate calculate, int input) {
        return calculate(input);
        // return calculate.invoke(input);
    }
    
    /** Func */
    public int ExecuteFunc(Func<int, int> calculate, int input) {
        return calculate(input);
    }
    
    /** Action */
    // public delegate void Print(int input);
    //  public int ExecuteAction(Func<int, int> calculate, Print<int> print, int input) {
     public int ExecuteAction(Func<int, int> calculate, Action<int> print, int input) {
        var res = calculate(input);
        print(res);
        return res;
    }

    /** EVENT */
    public event Action<object, CalculatorEventArgs> CalculateEvent; // Here, CalculateEvent is a Delegate
    public void RaiseEvent(string name) {
        CalculateEvent?.Invoke(this /* obj which is raising the event (Calculator) */, new CalculatorEventArgs { Name = name });
    }

    public int ExecuteEvent(Func<int, int> calculate, Action<int> print, int input) {
        var result = calculate(input);
        print(result);
        return result;
    }

}