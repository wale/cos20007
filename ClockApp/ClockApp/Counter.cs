namespace ClockApp;

public class Counter 
{
    private int _count;

    public Counter()
    {
        _count = 0;
    }

    public int Count 
    {
        get 
        {
            return _count;
        }
    }

    public void Increment()
    {
        _count++;
    }

    public void Reset()
    {
        _count = 0;
    }
}