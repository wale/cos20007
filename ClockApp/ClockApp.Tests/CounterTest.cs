using ClockApp;

namespace ClockApp.Tests;

public class CounterTest
{
    private Counter _counter;

    [SetUp]
    public void Setup()
    {
        _counter = new Counter();
    }

    // Check if the Counter always starts at zero.
    [Test]
    public void CounterStartTest()
    {
        Assert.IsTrue(_counter.Count == 0);
    }

    // Check if the Counter adds one to the count.
    [Test]
    public void CounterIncrementTest() 
    {
        _counter.Increment();
        Assert.IsTrue(_counter.Count == 1);
    }

    // Check if the Counter matches a specific number.
    [Test]
    public void CounterMatchTest() 
    {
        _counter.Reset();

        int countTo = 45;
        for (int i = 0; i < countTo; i++) {
            _counter.Increment();
        }

        Assert.IsTrue(_counter.Count == countTo);
    }

    // Check if the Counter resets down to zero.
    [Test]
    public void CounterResetTest()
    {
        _counter.Reset();
        
        Assert.IsTrue(_counter.Count == 0);
    }
}