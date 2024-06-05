using NUnit.Framework;

namespace MathNCodeCS._2024._06._04._0098.ValidateBinarySearchTree;

public class Test
{
    private Solution _solution = null!;

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                new TreeNode(),
                true);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(TreeNode? num, bool expected)
    {
        Assert.That(_solution.IsValidBST(num), Is.EqualTo(expected));
    }
}
