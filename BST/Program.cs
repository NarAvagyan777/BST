using System;

using System.Collections.Generic;

using System.Linq;
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val)
    {
        this.val = val;
        this.left = null;
        this.right = null;
    }
}

class MyBinaryTree
{
    public TreeNode? root;

    public MyBinaryTree()
    {
        root = null;
    }

    public TreeNode Insert(TreeNode? node, int val)
    {
        if (node == null)
        {
            return new TreeNode(val);
        }
        if (node.val > val)
        {
            node.left = Insert(node.left, val);
        }
        else if (node.val < val)
        {
            node.right = Insert(node.right, val);
        }
        return node;
    }
    public TreeNode Search(TreeNode? node, int val)
    {
        if (node == null)
        {
            return null;
        }
        if (node.val == val)
        {
            return node;
        }
        else if (val < node.val)
        {
            return Search(node.left, val);
        }
        else
        {
            return Search(node.right, val);
        }
    }
    public TreeNode Successor(TreeNode? node, TreeNode? target)
    {
        TreeNode prev = null;
        while (node != null)
        {
            if (node.val > target.val)
            {
                prev = node;
                node = node.left;
            }
            else
            {
                node = node.right;
            }
        }
        return prev;
    }
    public TreeNode PreSuccessor(TreeNode? node, TreeNode? target)
    {
        TreeNode prev = null;
        if (node == null)
        {
            return null;
        }
        while (node != null)
        {
            if (node.val < target.val)
            {
                prev = node;
                node = node.right;
            }
            else
            {
                node = node.left;
            }
        }
             return prev;
    }
    public TreeNode Getmin(TreeNode root)
    {
        while (root.left != null)
        {
            root = root.left;
        }
        return root;
    }
    public TreeNode GetMax(TreeNode root)
    {
        while (root.right != null)
        {
            root = root.right;
        }
        return root;
    }

}
class Program
{
    static void Main()
    {
        MyBinaryTree tree = new MyBinaryTree();


        tree.root = tree.Insert(tree.root, 50);
        tree.root = tree.Insert(tree.root, 30);
        tree.root = tree.Insert(tree.root, 70);
        tree.root = tree.Insert(tree.root, 20);
        tree.root = tree.Insert(tree.root, 40);
        tree.root = tree.Insert(tree.root, 60);
        tree.root = tree.Insert(tree.root, 80);

        //  TreeNode found1  = tree.Search(tree.root, 30);
        TreeNode found2 = tree.Search(tree.root, 50);
        //Console.WriteLine($"{tree.GetMax(found1).val}");
        //Console.WriteLine($"{tree.Getmin(found2).val}");
        Console.WriteLine($"{tree.PreSuccessor(tree.root,found2).val}");
    }
} 