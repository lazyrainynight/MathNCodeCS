using NUnit.Framework;

namespace MathNCodeCS._2024._05._09._1143.LongestCommonSubsequence;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase("", "", 0)]
    [TestCase("abcde", "ace", 3)]
    [TestCase("abc", "abc", 3)]
    [TestCase("abc", "def", 0)]
    [TestCase("their", "habit", 2)]
    [TestCase("HIEROGLYPHOLOGY", "MICHAELANGELO", 5)]
    [TestCase("ylqpejqbalahwr", "yrkzavgdmdgtqpg", 3)]
    public void AssertThis(string a, string b, int expected)
    {
        Assert.That(_solution.LongestCommonSubsequence(a, b), Is.EqualTo(expected));
    }
}
