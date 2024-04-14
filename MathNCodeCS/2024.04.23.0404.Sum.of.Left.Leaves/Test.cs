using NUnit.Framework;

namespace MathNCodeCS._2024._04._23._0404.Sum.of.Left.Leaves;

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
        Assert.That(_solution.SumOfLeftLeaves(root), Is.EqualTo(expected));
    }
}
