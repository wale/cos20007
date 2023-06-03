namespace Lab2._2;

class Counter 
{
    private int _count;
    private string _name;

    public string Name {
        get => _name;
        set 
        {
            _name = value;
        }
    }

    
    public int Ticks { get => this._count; }

    public Counter(string name) 
    {
        _count = 0;
        _name = name;
    }

    public void Increment() {
        this._count++;
    }

    public void Reset() {
        this._count = 0;
    }
}