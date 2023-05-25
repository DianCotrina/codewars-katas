using System.Linq;
// See https://aka.ms/new-console-template for more information
var result= NameShuffler("Jhon Doe");
Console.WriteLine(result);

static string NameShuffler(string str)
{
    string[] reverseName = str.Split(" ").Reverse().ToArray();
    
    return string.Join(" ", reverseName);
}