using NUnit.Framework;

namespace MathNCodeCS._2024._06._25._0136.SingleNumber;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(new[] { 2, 2, 1 }, 1);
            yield return new TestCaseData(new[] { 4, 1, 2, 1, 2 }, 4);
            yield return new TestCaseData(new[] { 1 }, 1);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int[] nums, int expected)
    {
        Assert.That(_solution.SingleNumber(nums), Is.EqualTo(expected));
    }
}
