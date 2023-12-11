namespace BinaryTree;
public class Node
{
    private int key;
    private int value;
    public Node Left { get; set; }
    public Node Rigth { get; set; }
    public int Key
    {
        get { return key; }
        set { key = value; }
    }
    
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }
    public Node() { }
    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
    }

    public void Insert(Node node, int key, int value) {
        if (node.key > key)
        {
            if (node.Left == null)
            {
                node.Left = new Node(key, value);
            }
            else 
            {
                Insert(node.Left, key, value);
            }
        }
        else if(node.key <= key) 
        {
            if(node.Rigth == null)
            {
                node.Rigth = new Node(key, value);
            }
            else 
            {
                Insert(node.Rigth, key, value);
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
        return node.key < targetkey ? Searach(node.Rigth, targetkey) : Searach(node.Left, targetkey);
    }

    public Node GetMin(Node node) {
        if (node == null)
        {
            return null;
        }
        else if (node.Left == null)
        {
            return node;
        }
        return GetMin(node.Left);
    }

    public Node GetMax(Node node) {
        if (node == null)
        {
            return null;
        }
        else if (node.Rigth == null)
        {
            return node;
        }
        return GetMax(node.Rigth);
    }

    public Node Delete(Node node, int key) {
        if(node == null) {
            return null;
        } 
        if(key > node.key) {
            node.Rigth = Delete(node.Rigth, key);
        } 
        else if(key < node.key) {
            node.Left = Delete(node.Left, key);
        } 
        else {
            if(node.Left == null || node.Rigth == null) {
                node = node.Left == null ? node.Rigth : node.Left;
            }
            else {
                Node maxInLeft = GetMax(node.Left);
                node.key = maxInLeft.Key;
                node.value = maxInLeft.Value;
                Delete(node.Rigth, maxInLeft.Key);
            }
        }

        return node;
    }

    public void PrintTree(Node node) {
        if(node == null) {
            return;
        }
        PrintTree(node.Left);
        Console.Write(node.Key  + " ");
        PrintTree(node.Rigth);
    }
}
