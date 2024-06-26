using NUnit.Framework;

namespace MathNCodeCS._2024._06._27._0338.CountingBits;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(2, new[] { 0, 1, 1 });
            yield return new TestCaseData(5, new[] { 0, 1, 1, 2, 1, 2 });
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int num, int[] expected)
    {
        Assert.That(_solution.CountBits(num), Is.EqualTo(expected));
    }
}
