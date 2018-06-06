/*
 1. Given a sorted (increasing order) array, write an algorithm to create a binary tree with
minimal height.
*/

public static TreeNode addToTree(int arr[], int start, int end)
{
    if (end < start)
    {
        return null;
    }
    int mid = (start + end) / 2;
    TreeNode n = new TreeNode(arr[mid]);
    n.left = addToTree(arr, start, mid - 1);
    n.right = addToTree(arr, mid + 1, end);
    return n;
}

public static TreeNode createMinimalBST(int array[])
{
    return addToTree(array, 0, array.length - 1);
}


/* 2. Implement a function to check if a tree is balanced. For the purposes of this question,
a balanced tree is defined to be a tree such that no two leaf nodes differ in distance
from the root by more than one.
*/
public static int maxDepth(TreeNode root)
{
    if (root == null)
    {
        return 0;
    }
    return 1 + Math.max(maxDepth(root.left), maxDepth(root.right));
}

public static int minDepth(TreeNode root)
{
    if (root == null)
    {
        return 0;
    }
    return 1 + Math.min(minDepth(root.left), minDepth(root.right));
}

public static boolean isBalanced(TreeNode root)
{
    return (maxDepth(root) - minDepth(root) <= 1);
}