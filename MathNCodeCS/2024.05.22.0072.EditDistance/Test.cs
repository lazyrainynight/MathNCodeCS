using NUnit.Framework;

namespace MathNCodeCS._2024._05._22._0072.EditDistance;

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
    [TestCase("abc", "", 3)]
    [TestCase("", "abc", 3)]
    [TestCase("horse", "ros", 3)]
    [TestCase("abd", "acd", 1)]
    [TestCase("dinitrophenylhydrazine", "acetylphenylhydrazine", 6)]
    public void AssertThis(string word1, string word2, int expected)
    {
        Assert.That(_solution.MinDistance(word1, word2), Is.EqualTo(expected));
    }
}
