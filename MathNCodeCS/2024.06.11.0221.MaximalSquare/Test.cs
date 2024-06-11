using NUnit.Framework;

namespace MathNCodeCS._2024._06._11._0221.MaximalSquare;

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
                    ['0'],
                },
                0);

            yield return new TestCaseData(
                new char[][]
                {
                    ['1'],
                },
                1);

            yield return new TestCaseData(
                new char[][]
                {
                    ['0', '1'],
                    ['1', '0']
                },
                1);

            yield return new TestCaseData(
                new char[][]
                {
                    ['1', '0', '1', '0', '0'],
                    ['1', '0', '1', '1', '1'],
                    ['1', '1', '1', '1', '1'],
                    ['1', '0', '0', '1', '0']
                },
                4);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(char[][] matrix, int expected)
    {
        Assert.That(_solution.MaximalSquare(matrix), Is.EqualTo(expected));
    }
}
