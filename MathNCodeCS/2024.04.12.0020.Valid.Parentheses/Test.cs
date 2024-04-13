using NUnit.Framework;

namespace MathNCodeCS._2024._04._12._0020.Valid.Parentheses;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("]", false)]
    [TestCase("[", false)]
    public void AssertThis(string s, bool expected)
    {
        Assert.That(_solution.IsValid(s), Is.EqualTo(expected));
    }
}
