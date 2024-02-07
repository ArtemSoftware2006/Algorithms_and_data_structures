using BinaryTree;

Node root = new Node(0, 0);

root.Insert(root, 2, 2);
root.Insert(root,-1, -1);
root.Insert(root,-100, -100);
root.Insert(root,100, 100);
root.Insert(root,10, 10);
root.Insert(root,-4, -4);

root.PrintTree(root);

Console.WriteLine();

root.Delete(root, 100);

root.PrintTree(root);