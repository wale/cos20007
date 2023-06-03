namespace SemesterTest;

class Program 
{
    static void Main(String[] args) 
    {
        var studentId = new List<int> { 1, 0, 4, 4, 2, 1, 3, 2, 0 };
        var analyser = new DataAnalyser(studentId, new AverageSummary());
        analyser.Summarise();
        analyser.AddNumber(3);
        analyser.AddNumber(7);
        analyser.AddNumber(6);
        analyser.Strategy = new MinMaxSummary();
        analyser.Summarise();
    }
}