using NUnit.Framework;

namespace MathNCodeCS._2024._07._02._0287.FindDuplicateNumber;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(new[] { 1, 3, 4, 2, 2 }, 2);
            yield return new TestCaseData(new[] { 3, 1, 3, 4, 2 }, 3);
            yield return new TestCaseData(new[] { 3, 3, 3, 3, 3 }, 3);
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
        Assert.That(_solution.FindDuplicate(nums), Is.EqualTo(expected));
    }
}
