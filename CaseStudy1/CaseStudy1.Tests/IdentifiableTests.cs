namespace CaseStudy1.Tests;

public class Tests
{
    private IdentifiableObject _object;
    [SetUp]
    public void Setup()
    {
        _object = new IdentifiableObject(new String[] { "duale", "siad", "wale" });
    }

    [Test]
    public void TestAreYou()
    {
        bool check = _object.AreYou("wale");
        Assert.IsTrue(check);
    }

    [Test]
    public void TestNotAreYou()
    {
        bool check = _object.AreYou("jess");
        Assert.IsFalse(check);
    }

    [Test]
    public void TestCaseSensitive()
    {
        bool check = _object.AreYou("duAlE");
        Assert.IsTrue(check);
    }

    [Test]
    public void TestFirstId()
    {
        bool check = _object.FirstId == "duale";
        Assert.IsTrue(check);
    }

    [Test]
    public void TestNoIds()
    {
        IdentifiableObject emptyObject = new IdentifiableObject(new String[] {});
        bool check = emptyObject.FirstId == "";
        Assert.IsTrue(check);
    }

    [Test]
    public void TestAddId()
    {
        _object.AddIdentifier("ben");
        bool check = _object.AreYou("ben");
        Assert.IsTrue(check);
    }
}