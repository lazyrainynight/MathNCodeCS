using NUnit.Framework;

namespace MathNCodeCS._2024._04._30._0695.Max.Area.of.Island;

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
                    [1, 1, 1, 1, 0],
                    [1, 1, 0, 1, 0],
                    [1, 1, 0, 0, 0],
                    [0, 0, 0, 0, 0],
                },
                9);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 1, 0, 0, 0],
                    [1, 1, 0, 0, 0],
                    [0, 0, 1, 0, 0],
                    [0, 0, 0, 1, 1],
                },
                4);

            yield return new TestCaseData(
                new int[][]
                {
                    [0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
                    [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
                    [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0],
                    [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0],
                    [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0],
                    [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
                    [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0],
                    [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0],
                },
                6);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int[][] grid, int expected)
    {
        Assert.That(_solution.MaxAreaOfIsland(grid), Is.EqualTo(expected));
    }
}
