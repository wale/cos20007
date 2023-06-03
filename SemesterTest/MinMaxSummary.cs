namespace SemesterTest;

class MinMaxSummary : SummaryStrategy
{
    public int Minimum(List<int> numbers)
    {
        var min = numbers[0];
        for (var i = 0; i < numbers.Count; i++) 
        {
            if(numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }

    public int Maximum(List<int> numbers) 
    {
        var max = 0;
        for (var i = 0; i < numbers.Count; i++) 
        {
            if(numbers[i] > max) 
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public override void PrintSummary(List<int> numbers) 
    {
        Console.WriteLine("The minimum value is {0} and the maximum is {1}", numbers.Min(), numbers.Max());
    }
}