using ClockApp;

namespace ClockApp.Tests;

public class ClockTest
{
    private Clock _clock;

    [SetUp]
    public void Setip() 
    {
        _clock = new Clock();
    }

    [Test]
    public void TickTest() 
    {
        string currentTime = "00:01:20";
        for (int i = 0; i < 80; i++) {
            _clock.Tick();
        }
        Assert.AreEqual(currentTime, _clock.CurrentTime);
    }

    [Test]
    public void CurrentTimeTest() 
    {
        string zeroedOut = "00:00:00";
        Assert.AreEqual(_clock.CurrentTime, zeroedOut);
    }

    [Test]
    public void LoopAndResetTest()
    {
        string currentTime = "00:00:00";
        for (int i = 0; i < 80; i++) {
            _clock.Tick();
        }
        _clock.Reset();
        Assert.AreEqual(currentTime, _clock.CurrentTime);
    }
}