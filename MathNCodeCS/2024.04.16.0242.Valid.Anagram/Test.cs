using NUnit.Framework;

namespace MathNCodeCS._2024._04._16._0242.Valid.Anagram;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase("", "", true)]
    [TestCase("anagram", "nagaram", true)]
    [TestCase("rat", "car", false)]
    public void AssertThis(string s, string t, bool expected)
    {
        Assert.That(_solution.IsAnagram(s, t), Is.EqualTo(expected));
    }
}
