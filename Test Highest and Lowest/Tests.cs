using NUnit.Framework;
using Solution;

[TestFixture]
public class ExampleTests
{
    [Test]
    public void Test1()
    {
        Assert.That(Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"), Is.EqualTo("42 -9"));
    }
    [Test]
    public void Test2()
    {
        Assert.That(Kata.HighAndLow("1 2 3"), Is.EqualTo("3 1"));
    }
}