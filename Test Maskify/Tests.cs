using NUnit.Framework;
using Test_Maskify;

[TestFixture]
public class Tests
{
    [Test]
    public void ExamplesTests()
    {
        Assert.That(Kata.Maskify("4556364607935616"), Is.EqualTo("############5616"));
        Assert.That(Kata.Maskify("1"), Is.EqualTo("1"));
        Assert.That(Kata.Maskify("11111"), Is.EqualTo("#1111"));
    }
}