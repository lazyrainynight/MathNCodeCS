using NUnit.Framework;

namespace MathNCodeCS._2024._05._23._0064.MinimumPathSum;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                new int[][]
                {
                    [1, 3, 1],
                    [1, 5, 1],
                    [4, 2, 1],
                },
                7);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 2, 3],
                    [4, 5, 6],
                },
                12);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int[][] input, int expected)
    {
        Assert.That(_solution.MinPathSum(input), Is.EqualTo(expected));
    }
}
