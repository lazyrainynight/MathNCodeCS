using NUnit.Framework;

namespace MathNCodeCS._2024._04._02.Two.Sum;

public class Test
{
    private Solution _solution = null!;

    [OneTimeSetUp]
    public void SetUp()
    {
        _solution = new Solution();
    }

    [Test]
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void AssertThis(int[] nums, int target, int[] expected)
    {
        Assert.That(_solution.TwoSum(nums, target), Is.EquivalentTo(expected));
    }
}
