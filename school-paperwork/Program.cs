// See https://aka.ms/new-console-template for more information
Console.WriteLine(PaperWork(5,5));
Console.WriteLine(PaperWork(5,-5));
Console.WriteLine(PaperWork(-5,-5));
Console.WriteLine(PaperWork(-5,5));
Console.WriteLine(PaperWork(5,0));

static int PaperWork(int n, int m) {
    bool isBelowZero = (n < 0) || (m < 0); 
    return isBelowZero ? 0 : n * m;
}