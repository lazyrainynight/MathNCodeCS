using NUnit.Framework;

namespace MathNCodeCS._2024._06._05._0105.ConstructBinaryTreeFromPreorderAndInorderTraversal;

public class Test
{
    private Solution _solution = null!;

    // preorder : 20, 10, 4, 1, 6, 15, 13, 17, 29, 23, 21, 24, 37, 32, 39
    // inorder  : 1, 4, 6, 10, 13, 15, 17, 20, 21, 23, 24, 29, 32, 37, 39

    // preorder : 30, 15, 7, 4, 1, 5, 10, 8, 11, 23, 19, 17, 21, 27, 24, 29, 45, 37, 33, 31, 34, 42, 41, 44, 60, 50, 65, 62
    // inorder  : 1, 4, 5, 7, 8, 10, 11, 15, 17, 19, 21, 23, 24, 27, 29, 30, 31, 33, 34, 37, 41, 42, 44, 45, 50, 60, 62, 65

    // preorder : 11, 8, 7, 9, 6, 10, 22, 17, 14, 21, 29, 20, 31, 30, 35
    // inorder  : 7, 8, 6, 9, 10, 11, 14, 17, 21, 22, 20, 29, 30, 31, 35

    // preorder : 31, 15, 6, 3, 1, 4, 12, 21, 19, 17, 20, 23, 42, 33, 47, 44, 53, 48, 59
    // inorder  : 1, 3, 4, 6, 12, 15, 17, 19, 20, 21, 23, 31, 33, 42, 44, 47, 48, 53, 59

    private static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(
                new[] { 3, 9, 20, 15, 7, },
                new[] { 9, 3, 15, 20, 7 },
                null);
        }
    }

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void AssertThis(int[] preorder, int[] inorder, TreeNode expected)
    {
        // todo
        // Assert.That(_solution.BuildTree(preorder, inorder), Is.EqualTo(expected));
    }
}
