using NUnit.Framework;

namespace MathNCodeCS._2024._05._01._0003.Longest.Substring.without.Repeating.Characters;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase("", 0)]
    [TestCase("abba", 2)]
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    public void AssertThis(string s, int expected)
    {
        Assert.That(_solution.LengthOfLongestSubstring(s), Is.EqualTo(expected));
    }
}
