using Generics;

var intItem = new ItemPrinter<int>();
intItem.SetItem(1);
intItem.PrintItem();

var strItem = new ItemPrinter<string>();
strItem.SetItem("one");
strItem.PrintItem();

var personItem = new ItemPrinter<Person>();
personItem.SetItem(new Person("Max", 34));
personItem.PrintItem();



public record Person(string Name, int age);