namespace Lab2._2;

public class Program 
{
    static void PrintCounters(Counter[] counters) 
    {
        foreach (Counter c in counters) {
            Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
        }
    }

    static void Main() 
    {
        Counter[] myCounters = new Counter[3];

        myCounters[0] = new Counter("Counter 1");
        myCounters[1] = new Counter("Counter 2");
        myCounters[2] = myCounters[0];

        for (var i = 0; i < 10; i++) {
            myCounters[0].Increment();
        }
        
        for (var i = 0; i < 15; i++) {
            myCounters[1].Increment();
        }

        PrintCounters(myCounters);
        myCounters[2].Reset();
        PrintCounters(myCounters);
    }
}