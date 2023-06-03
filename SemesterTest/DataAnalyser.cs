namespace SemesterTest;

class DataAnalyser 
{
    private List<int> _numbers;
    private SummaryStrategy _strategy;

    public SummaryStrategy Strategy 
    {
        get 
        {
            return _strategy;
        }
        set 
        {
            _strategy = value;
        }
    }

    public DataAnalyser(List<int> numbers, SummaryStrategy strategy)
    {
        this._strategy = strategy;
        this._numbers = numbers;
    }

    public DataAnalyser() : this(new List<int> {  }, new AverageSummary()) 
    {
        
    }

    public void AddNumber(int num) 
    {
        _numbers.Add(num);
    }

    public void Summarise()
    {
        _strategy.PrintSummary(_numbers);
    }
}