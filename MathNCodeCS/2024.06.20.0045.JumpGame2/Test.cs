using NUnit.Framework;

namespace MathNCodeCS._2024._06._20._0045.JumpGame2;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new[] { 2, 3, 1, 1, 4 }, 2)]
    [TestCase(new[] { 2, 3, 0, 1, 4 }, 2)]
    [TestCase(
        new[]
        {
            2, 0, 6, 9, 8, 4, 5, 0, 8, 9, 1, 2, 9, 6, 8, 8, 0, 6, 3, 1, 2, 2, 1, 2, 6, 5, 3, 1, 2, 2, 6, 4, 2, 4,
            3, 1, 3, 8, 2, 4, 0, 1, 2, 0, 1, 4, 6, 5, 8, 0, 7, 9, 3, 4, 6, 6, 5, 8, 9, 3, 4, 3, 7, 0, 4, 9, 0, 9,
            8, 4, 3, 0, 7, 7, 1, 9, 1, 9, 4, 9, 0, 1, 9, 5, 7, 7, 1, 5, 8, 2, 8, 2, 6, 8, 2, 2, 7, 5, 1, 7, 9, 6
        },
        18)]
    public void AssertThis(int[] nums, int expected)
    {
        Assert.That(_solution.Jump(nums), Is.EqualTo(expected));
    }
}
