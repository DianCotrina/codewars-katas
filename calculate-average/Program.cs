
// See https://aka.ms/new-console-template for more information
double[] nums = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
double[] nums2 = new double[] { 0 };
Console.WriteLine(FindAverage(nums));
Console.WriteLine(FindAverage(nums2));

static double FindAverage(double[] array){
    return array.Length == 0 ? 0 : array.Average();
}
