using BinaryTree;

namespace test;

public class BinaryTreeTest
{
    [Fact]
    public void Insert_OneValue_Count2() {
        int expected = 2;
        BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();

        tree.Insert(0, 0);
        tree.Insert(10, 10);

        Assert.Equal(expected, tree.Count);
    }
    [Fact]
    public void Insert_TenValue_Count10() {
        int expected = 100;
        BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();

        for (int i = 0; i < expected; i++)
        {
            tree.Insert(i, i);
        }

        Assert.Equal(expected, tree.Count);
    }
    [Fact]
    public void Contains_100_True() {
        int target = 100;
        BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();

        tree.Insert(0, 0);
        tree.Insert(10, 10);
        tree.Insert(100, 100);

        bool result = tree.Contains(target);

        Assert.True(result);
    }
    [Fact]
    public void Contains_123456_False() {
        int target = 123456;
        BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();

        tree.Insert(0, 0);
        tree.Insert(10, 10);
        tree.Insert(100, 100);

        bool result = tree.Contains(target);

        Assert.False(result);
    }
    [Fact]
    public void Search_100_Node() {
        int target = 100;
        BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();

        tree.Insert(0, 0);
        tree.Insert(10, 10);
        tree.Insert(100, 100);

        Node result = tree.Search(target);

        Assert.Equal(target, result.Key);
    }

    [Fact]
    public void Search_123456_Null() {
         int target = 123456;
        BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();

        tree.Insert(0, 0);
        tree.Insert(10, 10);
        tree.Insert(100, 100);

        Node result = tree.Search(target);

        Assert.Null(result);
    }



    //Тесты для Node.cs


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

    [Fact]
    public void Delete_NodeWithoutChildren_6Node() {
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root,-1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root,100, 100);
        root.Insert(root,10, 10);
        root.Insert(root,-4, -4);

        root.Delete(root, 100);

        Assert.Null(root.Searach(root, 100));
    }

    [Fact]
    public void Delete_NodeWithOneChild_6Node() {
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root,-1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root,100, 100);
        root.Insert(root,10, 10);
        root.Insert(root,-4, -4);

        root.Insert(root,101, 101);
        root.Delete(root, 101);

        Assert.Null(root.Searach(root, 101));
    }

    [Fact]
    public void Delete_NodeWithTwoChild_6Node() {
        Node root = new Node(0, 0);

        root.Insert(root, 2, 2);
        root.Insert(root,-1, -1);
        root.Insert(root,-100, -100);
        root.Insert(root,100, 100);
        root.Insert(root,10, 10);
        root.Insert(root,-4, -4);

        root.Delete(root, 0);

        Assert.Null(root.Searach(root, 0));
    }
}