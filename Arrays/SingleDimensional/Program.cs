int[] values = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var items = new Item[2];
items[0] = new Item("Guitar", 1);

Console.WriteLine(values[0]);
Console.WriteLine(items[0]);

public record Item(string Name, int Price); // Needs to be the put at the end, because we're inside main method

