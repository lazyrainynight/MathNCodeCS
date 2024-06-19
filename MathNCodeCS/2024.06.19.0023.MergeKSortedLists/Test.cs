using NUnit.Framework;

namespace MathNCodeCS._2024._06._19._0023.MergeKSortedLists;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                new ListNode[]
                {
                    new(),
                },
                new ListNode[]
                {
                    new(),
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
    public void AssertThis(ListNode?[]? lists, ListNode? expected)
    {
        var head = _solution.MergeKLists(lists);
        Assert.That(CompareLists(head, expected), Is.True);
    }

    private static bool CompareLists(ListNode? head, ListNode? expected)
    {
        throw new NotImplementedException();
    }
}
