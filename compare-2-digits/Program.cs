// See https://aka.ms/new-console-template for more information
Console.WriteLine(Compare(13,14));
Console.WriteLine(Compare(42,24));
Console.WriteLine(Compare(13,87));

// You are given 2 two-digit numbers. You should check if they are similar by comparing their numbers, and return the result in %.

static string Compare(int a, int b){
    int[] digits1 = a.ToString().Select(c => int.Parse(c.ToString())).ToArray();
    int[] digits2 = b.ToString().Select(c => int.Parse(c.ToString())).ToArray();

    int similarDigitsCount = digits1.Intersect(digits2).Count();
    double similarityPercentage = (double)similarDigitsCount / 2 * 100;

    return similarityPercentage.ToString()+'%';
}
