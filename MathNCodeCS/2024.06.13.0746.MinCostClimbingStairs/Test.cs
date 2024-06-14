using NUnit.Framework;

namespace MathNCodeCS._2024._06._13._0746.MinCostClimbingStairs;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(new[] { 10, 15, 20 }, 15);
            yield return new TestCaseData(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int[] cost, int expected)
    {
        Assert.That(_solution.MinCostClimbingStairs(cost), Is.EqualTo(expected));
    }
}
