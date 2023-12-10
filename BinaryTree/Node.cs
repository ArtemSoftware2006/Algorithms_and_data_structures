using System.Reflection;

namespace BinaryTree;
public class Node
{
    private int key;
    public int Key
    {
        get { return key; }
        set { key = value; }
    }
    
    private int value;
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    
    Node left;
    Node right;
    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
    }

    public void Insert(Node node, int key, int value) {
        if (node.key > key)
        {
            if (node.left == null)
            {
                node.left = new Node(key, value);
            }
            else 
            {
                Insert(node.left, key, value);
            }
        }
        else if(node.key <= key) 
        {
            if(node.right == null)
            {
                node.right = new Node(key, value);
            }
            else 
            {
                Insert(node.right, key, value);
            }
        }
    }

    public Node Searach(Node node, int targetkey) {
        if (node == null) 
        {
            return null;
        }
        else if (node.key == targetkey) {
            return node;
        }
        return node.key < targetkey ? Searach(node.right, targetkey) : Searach(node.left, targetkey);
    }

    public Node GetMin(Node node) {
        if (node == null)
        {
            return null;
        }
        else if (node.left == null)
        {
            return node;
        }
        return GetMin(node.left);
    }

    public Node GetMax(Node node) {
        if (node == null)
        {
            return null;
        }
        else if (node.right == null)
        {
            return node;
        }
        return GetMax(node.right);
    }
}
