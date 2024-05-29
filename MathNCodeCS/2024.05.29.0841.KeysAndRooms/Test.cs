using NUnit.Framework;

namespace MathNCodeCS._2024._05._29._0841.KeysAndRooms;

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
                    [1],
                    [2],
                    [3],
                    [],
                },
                true);

            yield return new TestCaseData(
                new int[][]
                {
                    [1, 3],
                    [3, 0, 1],
                    [2],
                    [0],
                },
                false);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(IList<IList<int>> rooms, bool expected)
    {
        Assert.That(_solution.CanVisitAllRooms(rooms), Is.EqualTo(expected));
    }
}
