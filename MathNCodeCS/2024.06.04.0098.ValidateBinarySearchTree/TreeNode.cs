namespace MathNCodeCS._2024._06._04._0098.ValidateBinarySearchTree;

public class TreeNode
{
    public int Val { get; set; }

    public TreeNode? Left { get; set; }

    public TreeNode? Right { get; set; }

    public TreeNode(
        int val = 0,
        TreeNode? left = null,
        TreeNode? right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }
}
