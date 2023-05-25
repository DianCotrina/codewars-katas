// See https://aka.ms/new-console-template for more information
Console.WriteLine(SequenceSum(1,5,3));

// Your task is to write a function which returns the sum of a sequence of integers.
// The sequence is defined by 3 non-negative values: start, end, step.
// If start value is greater than the end, your function should return 0. 
// If end is not the result of an integer number of steps, then don't add it to the sum. See the 4th example below.

static int SequenceSum(int start, int end, int step) {

    var sequence = Enumerable.Range(start, end - start + 1).Where(x => (x - start) % step == 0);

    return start>end ? 0 : sequence.Sum();
}
