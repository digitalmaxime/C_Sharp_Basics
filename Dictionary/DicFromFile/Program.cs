// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] config = File.ReadAllLines(@"./config.txt");
var dic = config
  .Where(x => x != "")
  .Select(x => x.Split('='))
  .ToDictionary(x => x[0], x => x[1]);

Console.WriteLine(dic);