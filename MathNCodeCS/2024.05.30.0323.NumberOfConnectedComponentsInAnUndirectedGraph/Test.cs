using NUnit.Framework;

namespace MathNCodeCS._2024._05._30._0323.NumberOfConnectedComponentsInAnUndirectedGraph;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                2,
                new int[][]
                {
                    [1, 0],
                },
                1);

            yield return new TestCaseData(
                5,
                new int[][]
                {
                    [0, 1],
                    [1, 2],
                    [3, 4],
                },
                2);

            yield return new TestCaseData(
                5,
                new int[][]
                {
                    [0, 1],
                    [1, 2],
                    [2, 3],
                    [3, 4],
                },
                1);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int n, int[][] edges, int expected)
    {
        Assert.That(_solution.CountComponents(n, edges), Is.EqualTo(expected));
    }
}
