using NUnit.Framework;

namespace MathNCodeCS._2024._07._03._0096.UniqueBinarySearchTrees;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 5)]
    [TestCase(4, 14)]
    [TestCase(5, 42)]
    [TestCase(6, 132)]
    [TestCase(7, 429)]
    [TestCase(8, 1430)]
    public void AssertThis(int n, int expected)
    {
        Assert.That(_solution.NumTrees(n), Is.EqualTo(expected));
    }
}
