namespace Tutorial1;

class Program
{
    static void Main(string[] args)
    {
        
        Message[] messages = new Message[5];

        messages[0] = new Message("Welcome back!");
        messages[1] = new Message("What a lovely name");
        messages[2] = new Message("Great name");
        messages[3] = new Message("Oh hi!");
        messages[4] = new Message("That's a silly name");

        
        Console.WriteLine("Hello World! What's your name?");
        string name = Console.ReadLine();
        if (name.ToLower() == "rico")
        {
            messages[0].Print();
        } else if (name.ToLower() == "ash")
        {
            messages[1].Print();
        } else if (name.ToLower() == "ben")
        {
            messages[2].Print();
        } else if (name.ToLower() == "josh")
        {
            messages[3].Print();
        }
        else
        {
            messages[4].Print();
        }
    }
}