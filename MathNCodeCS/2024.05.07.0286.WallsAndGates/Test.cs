using NUnit.Framework;

namespace MathNCodeCS._2024._05._07._0286.WallsAndGates;

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
                    [-1],
                },
                new int[][]
                {
                    [-1]
                });

            yield return new TestCaseData(
                new int[][]
                {
                    [2147483647, -1, 0, 2147483647],
                    [2147483647, 2147483647, 2147483647, -1],
                    [2147483647, -1, 2147483647, -1],
                    [0, -1, 2147483647, 2147483647],
                },
                new int[][]
                {
                    [3, -1, 0, 1],
                    [2, 2, 1, -1],
                    [1, -1, 2, -1],
                    [0, -1, 3, 4]
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
    public void AssertThis(int[][] rooms, int[][] expected)
    {
        _solution.WallsAndGates(rooms);
        Assert.That(rooms, Is.EqualTo(expected));
    }
}
