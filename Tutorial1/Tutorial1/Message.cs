namespace Tutorial1;

public class Message
{
    private String _text;

    public Message(String text)
    {
        this._text = text;
    }

    public void Print()
    {
        Console.WriteLine(this._text);
    }
}