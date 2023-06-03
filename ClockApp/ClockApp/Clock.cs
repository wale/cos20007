namespace ClockApp;
public class Clock
{
    private Counter _seconds, _minutes, _hours;
    public Clock()
    {
        _seconds = new Counter();
        _minutes = new Counter();
        _hours = new Counter();
    }

    public string CurrentTime 
    {
        get {
            return $"{_hours.Count.ToString("00")}:{_minutes.Count.ToString("00")}:{_seconds.Count.ToString("00")}";
        }
    }

    public void Reset()
    {
        _seconds.Reset();
        _minutes.Reset();
        _hours.Reset();
    }

    public void Tick()
    {
        if (_seconds.Count < 59)
        {
            _seconds.Increment();
        }
        else
        {
            _seconds.Reset();
            if (_minutes.Count < 59)
            {
                _minutes.Increment();
            }
            else
            {
                _minutes.Reset();
                if (_hours.Count > 23)
                {
                    _hours.Reset();
                }
                else
                {
                    _hours.Increment();
                }
            }
        }
    }
}