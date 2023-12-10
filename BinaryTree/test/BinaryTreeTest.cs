

using BinaryTree;
using Xunit.Sdk;

namespace test;

public class BinaryTreeTest
{
    [Fact]
    public void GetMin_MinIsMinus100()
    {
        int expected = -100;
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root,-1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root,100, 100);
        root.Insert(root,10, 10);
        root.Insert(root,-4, -4);
        
        Node result = root.GetMin(root);

        Assert.Equal(expected, result.Key);
    }

    [Fact]
    public void GetMax_Max100()
    {
        int expected = 100;
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root, -1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root, 100, 100);
        root.Insert(root, 10, 10);
        root.Insert(root, -4, -4);
        
        Node result = root.GetMax(root);

        Assert.Equal(expected, result.Key);
    }

     [Fact]
    public void Search_ValueInTree_10()
    {
        int expected = 10;
        int targer = 10;
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root, -1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root, 100, 100);
        root.Insert(root, 10, 10);
        root.Insert(root, -4, -4);
        
        Node result = root.Searach(root, targer);

        Assert.Equal(expected, result.Key);
    }

    [Fact]
    public void Search_ValueNotInTree_null()
    {
        int target = 100000;
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root, -1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root, 100, 100);
        root.Insert(root, 10, 10);
        root.Insert(root, -4, -4);
        
        Node result = root.Searach(root, target);

        Assert.Null(result);
    }
}