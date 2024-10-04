using System.Collections.Generic;

namespace BST;

class BSTNode
{
    public int data;
    public BSTNode left;
    public BSTNode right;
}

class BSTImplement()
{
    /// <summary>
    /// 根節點
    /// </summary>
    public BSTNode root = null;

    /// <summary>
    /// 建立第一個node
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public BSTNode GetNewNode(int data)
    {
        BSTNode newNode = new BSTNode();
        newNode.data = data;
        newNode.left = null;
        newNode.right = null;
        return newNode;
    }

    public BSTNode Insert(BSTNode node, int data)
    {
        if (root == null)
        {
            root = GetNewNode(data);
            return root;
        }
        else if (node == null)
        {
            node = GetNewNode(data);
            return node;
        }

        if (data <= node.data)
        {
            node.left = Insert(node.left, data);
        }
        else
        {
            node.right = Insert(node.right, data);
        }
        return node;
    }

    public bool Search(BSTNode node, int data)
    {
        if (root == null)
        {
            return false;
        }
        else if (node == null)
        {
            return false;
        }
        else if (data == node.data)
        {
            return true;
        }
        else if (data <= node.data)
        {
            return Search(node.left, data);
        }
        else
        {
            return Search(node.right, data);
        }
    }

    /// <summary>
    /// 查詢最小值
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public int FinMin(BSTNode node)
    {
        if (node == null)
        {
            Console.WriteLine("Tree is empty !!!");
            return -1;
        }

        while (node.left != null)
        {
            node = node.left;
        }
        return node.data;
    }

    /// <summary>
    /// 查詢最小值，使用遞迴
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public int FinMinRecursion(BSTNode node)
    {
        if (node == null)
        {
            Console.WriteLine("Tree is empty !!!");
            return -1;
        }
        else if (node.left == null)
        {
            return node.data;
        }

        return FinMinRecursion(node.left);
    }

    /// <summary>
    /// 找出樹的高度，使用遞迴
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int FindHeight(BSTNode root)
    {
        if (root == null)
        {
            return -1;
        }
        int leftHeight = FindHeight(root.left);
        int rightHeight = FindHeight(root.right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}