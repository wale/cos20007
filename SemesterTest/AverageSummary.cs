namespace SemesterTest;

class AverageSummary : SummaryStrategy
{ 
    public float Average(List<int> numbers) 
    {
        var sum = 0;

        for (var i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }
        
        return sum / numbers.Count;
    }

    public override void PrintSummary(List<int> numbers)
    {
        Console.WriteLine("The average is {0}", (float) numbers.Average());
    }
}