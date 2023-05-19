namespace Generics;

internal class ItemPrinter<T>
{
    private T item;

    public void SetItem(T item) => this.item = item;

    public void PrintItem() => System.Console.WriteLine(this.item);
}