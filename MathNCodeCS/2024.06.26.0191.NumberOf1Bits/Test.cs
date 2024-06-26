using NUnit.Framework;

namespace MathNCodeCS._2024._06._26._0191.NumberOf1Bits;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(11, 3)]          // 1011
    [TestCase(128, 1)]         // 10000000
    [TestCase(645, 4)]         // 1010000101
    [TestCase(2147483645, 30)] // 1111111111111111111111111111101
    public void AssertThis(int num, int expected)
    {
        Assert.That(_solution.HammingWeight(num), Is.EqualTo(expected));
    }
}
