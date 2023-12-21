
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

        public BinaryTree(int key, int value) {
            Root = new Node(key, value);
            Count = 1;
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

        public Node GetMin() {
            return GetMin(Root);
        }
        private Node GetMin(Node node) {
            if (node == null)
            {
                return null;
            }
            else if(node.Left == null) {
                return node;
            }
            return GetMin(node.Left);
            
        }

        public Node GetMax() {
            return GetMax(Root);
        }
        private Node GetMax(Node node) {
            if (node == null)
            {
                return null;
            }
            else if(node.Rigth == null) {
                return node;
            }
            return GetMax(node.Rigth);
        }

        public bool Remove(int key) {
            if (Root is null)
            {
                return false;
            }
            bool result = Remove(Root, key);

            if (result)
            {
                Count--; 
            }

            return result;
        }

        private bool Remove(Node node, int key)
        {
            if (node is null)
            {
                return false;
            }
            else if (key > node.Key)
            {
                Remove(node.Rigth, key);
            }
            else if(key < node.Key) 
            {
                Remove(node.Left, key);
            }
            else {
                if(node.Left == null || node.Rigth == null)
                {
                    node = node.Left == null ? node.Rigth : node.Left;
                }    
                else 
                {
                    Node maxInLeft = GetMax(node.Left);
                    node.Key = maxInLeft.Key;
                    node.Value = maxInLeft.Value;
                    Remove(node.Left, maxInLeft.Key);
                }
            }
            return true;
        }
    }
}