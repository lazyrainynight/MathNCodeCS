using NUnit.Framework;

namespace MathNCodeCS._2024._04._26._0200.Number.of.Islands;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                new char[][]
                {
                    ['1', '1', '1', '1', '0'],
                    ['1', '1', '0', '1', '0'],
                    ['1', '1', '0', '0', '0'],
                    ['0', '0', '0', '0', '0'],
                },
                1);

            yield return new TestCaseData(
                new char[][]
                {
                    ['1', '1', '0', '0', '0'],
                    ['1', '1', '0', '0', '0'],
                    ['0', '0', '1', '0', '0'],
                    ['0', '0', '0', '1', '1'],
                },
                3);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(char[][] grid, int expected)
    {
        Assert.That(_solution.NumIslands(grid), Is.EqualTo(expected));
    }
}
