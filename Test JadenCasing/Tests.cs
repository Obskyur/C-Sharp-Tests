using Test_JadenCasing;

[TestFixture]
public class JadenCaseTest
{
    [Test]
    public void FixedTest()
    {
        Assert.That("How can mirrors be real if our eyes aren't real".ToJadenCase(), Is.EqualTo("How Can Mirrors Be Real If Our Eyes Aren't Real"),
                        "Strings didn't match.");
    }
}