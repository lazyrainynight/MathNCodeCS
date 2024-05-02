using NUnit.Framework;

namespace MathNCodeCS._2024._05._02._0567.PermutationInString;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase("ab", "eidbaooo", true)]
    [TestCase("ab", "eidboaoo", false)]
    [TestCase("abc", "abcxyzbca", true)]
    public void AssertThis(string s1, string s2, bool expected)
    {
        Assert.That(_solution.CheckInclusion(s1, s2), Is.EqualTo(expected));
    }
}
