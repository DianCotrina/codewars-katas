// See https://aka.ms/new-console-template for more information
Console.WriteLine(Hero(10,5));

static bool Hero(int bullets, int dragons){
    return dragons*2<=bullets;
}