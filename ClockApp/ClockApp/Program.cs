namespace ClockApp;

class Program 
{
    static void Main(string[] args)
    {
        Clock clock = new Clock();

        // Loop 120 times (120 ticks = 120 seconds), which *should* equal 2 hours.
        for (int i = 0; i < 80; i++) { 
            clock.Tick();
            Thread.Sleep(200); // Update every 200ms
            Console.Write("\r{0}", clock.CurrentTime); // Change the clock on the current line.
        }
    }
}