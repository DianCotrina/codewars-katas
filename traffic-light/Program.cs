// See https://aka.ms/new-console-template for more information
Console.WriteLine(UpdateLight("green"));
Console.WriteLine(UpdateLight("yellow"));
Console.WriteLine(UpdateLight("red"));

static string UpdateLight(string current){
    if (current=="green")
    {
        return "yellow";
    }
    else if(current == "yellow")
    {
        return "red";
    }
    else
    {
        return "green";
    }
}