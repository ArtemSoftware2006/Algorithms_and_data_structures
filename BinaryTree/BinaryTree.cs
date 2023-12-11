namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; private set; }
        public int Count { get; private set; }
        public BinaryTree() {
            Root = new Node();
            Count = 0;
        }

        public void Insert(int key, int value) {
            if (Root is null)
            {
                Root = new Node(key, value);
            } 
            else 
            {
                Insert(Root, key, value);
            }

            Count++;
        }

        private void Insert(Node node, int Key, int value) {
        if (node.Key > Key)
        {
            if (node.Left == null)
            {
                node.Left = new Node(Key, value);
            }
            else 
            {
                Insert(node.Left, Key, value);
            }
        }
        else if(node.Key <= Key) 
        {
            if(node.Rigth == null)
            {
                node.Rigth = new Node(Key, value);
            }
            else 
            {
                Insert(node.Rigth, Key, value);
            }
        }
    }

        
        public bool Contains(int key) {
            return Search(Root, key) is not null;
        }

        public Node Search(int key) {
            return Search(Root, key);
        }
        private Node Search(Node node, int key) {
            if (node == null)
            {
                return null;
            }
            else if(node.Key == key) {
                return node;
            }
            return key > node.Key ? Search(node.Rigth, key) : Search(node.Left, key);
        }
    }

}