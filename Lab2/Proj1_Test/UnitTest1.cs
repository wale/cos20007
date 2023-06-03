using Proj1;

namespace Proj1_Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void TestString()
    {
        Assert.AreSame("this must be true", "this must be true");
    }

    [Test]
    public void TestString2() {
        Assert.AreNotSame("this must be false", "cap, this must be true");
    }
}