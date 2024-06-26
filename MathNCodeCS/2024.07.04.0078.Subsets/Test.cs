using NUnit.Framework;

namespace MathNCodeCS._2024._07._04._0078.Subsets;

public class Test
{
    private Solution _solution = null!;

    public static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                Array.Empty<int>(),
                new int[][]
                {
                    [],
                });

            yield return new TestCaseData(
                new[] { 1 },
                new int[][]
                {
                    [],
                    [1],
                });

            yield return new TestCaseData(
                new[] { 1, 2, 3 },
                new int[][]
                {
                    [],
                    [1],
                    [2],
                    [3],
                    [1, 2],
                    [1, 3],
                    [2, 3],
                    [1, 2, 3],
                });
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int[] nums, IList<IList<int>> expected)
    {
        Assert.That(_solution.Subsets(nums), Is.EquivalentTo(expected));
    }
}
