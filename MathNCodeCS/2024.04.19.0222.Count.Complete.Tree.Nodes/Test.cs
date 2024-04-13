using NUnit.Framework;

namespace MathNCodeCS._2024._04._19._0222.Count.Complete.Tree.Nodes;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(null, 0)]
    public void AssertThis(TreeNode? root, int expected)
    {
        Assert.That(_solution.CountNodes(root), Is.EqualTo(expected));
    }
}
